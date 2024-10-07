using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace lab1_1
{
    public partial class DatabaseForm : Form
    {
        public Database ThisDB;
        public DatabaseForm(string name)
        {
            InitializeComponent();
            this.Text = name;
            this.ThisDB = new Database(name);
            string pathTables = "TextData\\" + name + "\\tables.txt"; //завантаження імен таблиць
            string pathSchemes = "TextData\\" + name + "\\schemes.txt"; //завантаження схем таблиць
            this.ThisDB.LoadTables(pathTables, pathSchemes); //запис даних про таблиці до об'єкту
            Collection<string> names = new Collection<string>();
            foreach (Table t in ThisDB.GetTables())  //заповнення елементів форми значеннями
            { 
                this.TableListBox.Items.Add(t.Name);
                this.LeftTableComboBox.Items.Add(t.Name);
                this.RightTableComboBox.Items.Add(t.Name);
            }
            this.RenameTextBox.Text = name;
        }

        private void NewTableButton_Click(object sender, EventArgs e) //нова таблиця одразу пишеться на диск
        {
            using (NewTableForm form = new NewTableForm(this.ThisDB))
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Table result = form.resultTable;
                    this.TableListBox.Items.Add(result.Name);
                    this.ThisDB.AddTable(result);
                }
        }

        private void TableListBox_SelectedIndexChanged(object sender, EventArgs e) //зміни в таблицях також пишуться на диск
        {
            Table table = this.ThisDB.GetTables()[this.TableListBox.SelectedIndex];//після виходу з форми, файл переписується
            TableForm form = new TableForm(table, ThisDB);
            form.Show();
        }

        protected void Dispose()
        {
            ThisDB.SaveClean();
            
            string tables = "";
            foreach (Table t in this.ThisDB.GetTables()) tables = tables + t.Name + "\n";
            System.IO.File.WriteAllText("TextData\\" + Name + "\\tables.txt", tables);

            string schemes = "";
            foreach (Table t in this.ThisDB.GetTables())
            {
                foreach ((string, string) s in t.Scheme) schemes = schemes + s.Item1 + "|" + s.Item2 + "|";
                schemes.Remove(schemes.Length - 2);
                schemes += "\n";
            }
            System.IO.File.WriteAllText("TextData\\" + Name + "\\schemes.txt", schemes);
        }

        ~DatabaseForm()
        {
            Dispose();
        }

        private void IntersectionButton_Click(object sender, EventArgs e)
        {
            if (LeftTableComboBox.SelectedItem != null && RightTableComboBox.SelectedItem != null)
            { 
                Collection<Table> tables = this.ThisDB.GetTables();
                int i=-1, j=-1;
                foreach (Table t in tables)
                {
                    if (t.Name == LeftTableComboBox.SelectedItem.ToString()) i = tables.IndexOf(t);
                    if (t.Name == RightTableComboBox.SelectedItem.ToString()) j = tables.IndexOf(t);
                }
                if (i != -1 && j != -1) { 
                    IEnumerable<IEnumerable<string>> resultEntries = ThisDB.Intersect(tables[i], tables[j]);
                    IntersectTableForm form = new IntersectTableForm(resultEntries, tables[i].Scheme);
                    form.Show();
                }
                else MessageBox.Show("Given tables have zero intersection");
            }
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            if (this.RenameTextBox.Text!="" && Validator.ValidateNameForPath(this.RenameTextBox.Text))
            {
                string oldName = ThisDB.Name;
                string newName = this.RenameTextBox.Text;

                ThisDB.Name= newName;
                this.Text = newName;
                string oldPath = "TextData\\" + oldName;
                string newPath = "TextData\\" + newName;
                Directory.Move(oldPath,newPath);
                this.RenameTextBox.Text = "";
                string[] dbs = File.ReadAllLines("TextData\\databases.txt");
                List<string> dbsList = dbs.ToList();
                int indexRenamed = dbsList.IndexOf(oldName);
                dbsList[indexRenamed] = newName;
                File.WriteAllLines("TextData\\databases.txt", dbsList);

            }
        }
    }
}
