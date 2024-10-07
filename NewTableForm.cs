using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_1
{
    public partial class NewTableForm : Form
    {
        Database thisDB;
        public Table resultTable;
        public NewTableForm(Database db)
        {
            InitializeComponent();
            this.Text = "New table";
            this.thisDB = db;
        }

        private void AddColumnButton_Click(object sender, EventArgs e)
        {
            if (this.ColumnNameTextbox.Text != "" && this.ColumnTypeComboBox.SelectedItem != null)
            {
                this.TableNameListBox.Items.Add(ColumnNameTextbox.Text);
                this.TableTypeListBox.Items.Add(this.ColumnTypeComboBox.SelectedItem.ToString());
            }
        }

        private void TableSubmitButton_Click(object sender, EventArgs e)
        {
            this.NameInvalidLabel.Visible = false;
            string name = this.TableNameTextBox.Text;
            if (name != "" && Validator.ValidateNameForPath(name))
            {
                Collection<(string, string)> scheme = new Collection<(string, string)>();
                
                for (int i = 0; i < this.TableNameListBox.Items.Count; i++)
                {
                    scheme.Add((this.TableTypeListBox.Items[i].ToString(),this.TableNameListBox.Items[i].ToString()));
                }
                //Collection<Entry> entries = new Collection<Entry>() { };
                resultTable = new Table(name, scheme, this.thisDB.Name);

                this.DialogResult = DialogResult.OK;
            }

            else
            {
                this.NameInvalidLabel.Visible = true;
            }
        }

    }
}
