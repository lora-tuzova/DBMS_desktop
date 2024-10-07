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

namespace lab1_1
{
    public partial class EditTableForm : Form
    {
        public Table thisTable;
        public Collection<(string, string)> resultScheme=new Collection<(string, string)>();
        public EditTableForm(Table table)
        {
            InitializeComponent();
            this.Text = "Edit";
            thisTable = table;
            Collection<(string, string)> scheme = table.Scheme;
            foreach ((string, string) s in scheme)
            {
                this.ColumnListBox.Items.Add(s.Item1 + "|" + s.Item2);
                //this.ColumnListBox.SelectedItems.Add(this.ColumnListBox.Items[this.ColumnListBox.Items.Count - 1]);
            }
            TableNameLabel.Text += thisTable.Name;
        }

        private void AddColumnButton_Click(object sender, EventArgs e)
        {
            if (this.ColumnNameTextbox.Text != "" && this.ColumnTypeComboBox.SelectedItem != null)
            {
                this.ColumnListBox.Items.Add(this.ColumnTypeComboBox.SelectedItem.ToString() + "|" + ColumnNameTextbox.Text);
                //this.ColumnListBox.SelectedItems.Add(this.ColumnListBox.Items[this.ColumnListBox.Items.Count - 1]);
                
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            foreach (string i in this.ColumnListBox.CheckedItems)
            {
                string[] items = i.Split('|');
                resultScheme.Add((items[0], items[1]));
            }
            DialogResult = DialogResult.OK;

        }
    }

}
