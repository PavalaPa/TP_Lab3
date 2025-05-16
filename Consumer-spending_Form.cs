using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace TP_Lab3
{
    public partial class Consumer_spending_Form : Form
    {
        public Consumer_spending_Form()
        {
            InitializeComponent();
        }

        private void Expenses_openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        //Открытие таблицы
        private void Open_expenses_button_Click(object sender, EventArgs e)
        {
            if (Expenses_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = Expenses_openFileDialog.FileName;
                string[] lines = File.ReadAllLines(filename);
                string[] columns = lines[0].Split(';');
                //Добавление столбцов
                foreach (string column in columns)
                {
                    Expenses_dataGridView.Columns.Add(column, column);
                }
                //Добавление строк
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(';');
                    Expenses_dataGridView.Rows.Add(fields);
                }
            }

        }
    }
}
