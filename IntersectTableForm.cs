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
    public partial class IntersectTableForm : Form
    {
        public IntersectTableForm(IEnumerable<IEnumerable<string>> entries, Collection<(string, string)> scheme)
        {
            InitializeComponent();
            this.Text = "Result";
            this.TableContentGrid.ColumnCount = scheme.Count; //створення стовпців
            int colCount = scheme.Count; //кількість стовпчиків
            for (int i = 0; i < colCount; i++)
            {
                this.TableContentGrid.Columns[i].HeaderText = scheme[i].Item2 + "\n(" + scheme[i].Item1 + ")";
            }
            foreach (IEnumerable<string> entry in entries)
            {
                this.TableContentGrid.Rows.Add(entry.ToArray()); //заповнення рядків таблиці
            }
        }
    }
}
