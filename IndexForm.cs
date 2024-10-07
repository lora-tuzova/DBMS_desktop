using System;
using System.Collections.Generic;
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
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
            this.Text = "Database list";
            string[] lines = File.ReadAllLines("TextData/databases.txt");
            foreach (string line in lines) this.DBListBox.Items.Add(line);
        }

        private void DBListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseForm form = new DatabaseForm(DBListBox.Items[DBListBox.SelectedIndex].ToString());
            form.Show();
        }

        private void NewDBButton_Click(object sender, EventArgs e)
        {
            if (DBNameTextBox.Text != "" && Validator.ValidateNameForPath(DBNameTextBox.Text))
            {
                this.InvalidNameLabel.Text = "";
                DBListBox.Items.Add((string)DBNameTextBox.Text);
                Directory.CreateDirectory("TextData\\" + (string)DBNameTextBox.Text);
                File.Create("TextData\\" + (string)DBNameTextBox.Text+"\\tables.txt");
            }

            else this.InvalidNameLabel.Text = "Invalid name, try again";
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.DBListBox.Items.Clear();
            string[] lines = File.ReadAllLines("TextData/databases.txt");
            foreach (string line in lines) this.DBListBox.Items.Add(line);
        }
    }
}
