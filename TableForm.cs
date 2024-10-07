using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab1_1
{
    public partial class TableForm : Form
    {
        Table thisTable;
        Database thisDB;
        public TableForm(Table thisTable, Database thisDB)
        {
            InitializeComponent();
            this.Text = thisTable.Name;
            this.thisTable = thisTable;
            this.thisDB = thisDB;
            thisTable.LoadEntries(); //підвантаження рядків з файлу
            Collection<Entry> entries = thisTable.GetEntries();
            Collection<(string, string)> scheme = thisTable.Scheme;
            this.TableContentGrid.ColumnCount = scheme.Count; //створення стовпців
            int colCount = scheme.Count; //кількість стовпчиків
            for (int i = 0; i < colCount; i++) {
                this.TableContentGrid.Columns[i].HeaderText = scheme[i].Item2 + "\n(" + scheme[i].Item1 + ")"; //створення хедерів стовпців на основі схеми таблиці
                switch (scheme[i].Item1) {
                    case "integer":
                        this.TableContentGrid.Columns[i].ValueType = typeof(int);
                        break;
                    case "string":
                        this.TableContentGrid.Columns[i].ValueType = typeof(string);
                        break;
                    case "char":
                        this.TableContentGrid.Columns[i].ValueType = typeof(char);
                        break;
                    case "real":
                        this.TableContentGrid.Columns[i].ValueType = typeof(float);
                        break;
                    case "time":
                        this.TableContentGrid.Columns[i].ValueType = typeof(string);
                        this.TableContentGrid.Columns[i].Name = "time";
                        break;
                    case "timeInvl":
                        this.TableContentGrid.Columns[i].ValueType = typeof(string);
                        this.TableContentGrid.Columns[i].Name = "timeInvl";
                        break;
                    default: break;
                }

            }
            foreach (Entry entry in entries) {
                this.TableContentGrid.Rows.Add(entry.Content.ToArray()); //заповнення рядків таблиці

            }
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true  // Show "Delete" text on each button
            };

            TableContentGrid.Columns.Add(deleteButtonColumn);

            

        }

        private void TableContentGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"Data error at row {e.RowIndex + 1}, column {e.ColumnIndex + 1}: {e.Exception.Message}",
                            "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ThrowException = false; //викидається дефолтна помилка, виняток відміняється, щоби програма екстрено не зупинилась
        }

        private void TableContentGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string cellValue = e.FormattedValue.ToString();
            Type columnType = TableContentGrid.Columns[e.ColumnIndex].ValueType; //визначається тип даних стовпця

            if (columnType == typeof(int))
            {
                if (!int.TryParse(cellValue, out _))
                {
                    MessageBox.Show("You have to enter an integer number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }

            else if (columnType == typeof(float))
            {
                if (!float.TryParse(cellValue, out _))
                {
                    MessageBox.Show("You have to enter a real number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }

            else if (columnType == typeof(char))
            {
                if (cellValue.Length != 1)
                {
                    MessageBox.Show("You have to enter a single character.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }

            else if (TableContentGrid.Columns[e.ColumnIndex].Name == "time")
            {
                if (!Validator.ValidateTime(cellValue))
                {
                    MessageBox.Show("You have to enter a valid time (hh:mm:ss).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
            
            else if (TableContentGrid.Columns[e.ColumnIndex].Name == "timeInvl")
            {
                if (!Validator.ValidateTimeInterval(cellValue))
                {
                    MessageBox.Show("You have to enter a valid time interval (hh:mm:ss-hh:mm:ss).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }



        private void SaveButton_Click(object sender, EventArgs e)
        {
            Collection<Entry> entries = new Collection<Entry>(); 
            Collection<string> rows = new Collection<string>();
            foreach (DataGridViewRow r in TableContentGrid.Rows)
            {
                if (!r.IsNewRow)
                {
                    foreach (DataGridViewCell s in r.Cells)
                        rows.Add(s.Value.ToString());
                    Entry newEntry = new Entry(rows.ToArray(), thisTable.Name);
                    entries.Add(newEntry);
                    rows.Clear();
                }
            }
            foreach (Entry entryTemp in entries) entryTemp.Content.Remove(entryTemp.Content.Last());

            string entry = "";
            string file = "";
            foreach (Entry k in entries)
            {
                int i = 0;
                foreach (string s in k.Content)
                {
                    i++;
                    if (i == k.Content.Count) entry = entry + s;
                    else entry = entry + s + "|";
                }
                file += entry;
                file += "\n";
                entry = "";

            }
            System.IO.File.WriteAllText("TextData\\" + thisDB.Name + "\\" + thisTable.Name + ".txt", file);

            thisTable.LoadEntries();

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string[] entries = File.ReadAllLines("TextData\\" + thisDB.Name + "\\" + thisTable.Name + ".txt");
            if (entries.Length > 0)
            {
                MessageBox.Show("You can only edit table's columns if this table is empty.");
            }
            else
            {
                EditTableForm form = new EditTableForm(thisTable);
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                   

                    string oldScheme = "";
                    int j = 0; int k=0;
                    foreach ((string, string) s in thisTable.Scheme)
                    {
                        if (j== thisTable.Scheme.Count-1) oldScheme = oldScheme + s.Item1 + "|" + s.Item2;
                        else oldScheme = oldScheme + s.Item1 + "|" + s.Item2 + "|";//запис попередньої схеми в рядок
                        j++;
                    }

                    thisTable.Scheme = form.resultScheme;

                    string stringScheme = "";
                    foreach ((string, string) s in thisTable.Scheme)
                    {
                        if (k == thisTable.Scheme.Count - 1) stringScheme = stringScheme + s.Item1 + "|" + s.Item2;
                        else stringScheme = stringScheme + s.Item1 + "|" + s.Item2 + "|";//запис отриманої схеми в рядок
                        k++;
                    }
                        

                    string[] schemes = File.ReadAllLines("TextData\\" + thisDB.Name + "\\schemes.txt"); //отримані усі схеми
                    int i = 0;
                    foreach (string line in schemes) { 
                        if (line == oldScheme) schemes[i] = stringScheme;//заміна старої схеми на нову
                        i++;
                    }

                    string newSchemes = "";
                    for (int c =0; c < schemes.Length; c++)
                    {
                        newSchemes+= schemes[c];
                        newSchemes += "\n";
                    }

                    System.IO.File.WriteAllText("TextData\\" + thisDB.Name + "\\schemes.txt", newSchemes);//повертання усіх схем до файлу

                }
            }
        }

        private void TableContentGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == TableContentGrid.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                TableContentGrid.Rows.RemoveAt(e.RowIndex);
            }
        }
    }

}
