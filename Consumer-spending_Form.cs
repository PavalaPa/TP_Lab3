using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Drawing.Text;

namespace TP_Lab3
{
    public partial class Consumer_spending_Form : Form
    {
        public Consumer_spending_Form()
        {
            InitializeComponent();
        }

        //Загрузка таблицы на форму
        private void Load_to_Form()
        {
            //Очистка таблицы перед добавлением данных
            Expenses_dataGridView.Columns.Clear();
            Expenses_dataGridView.Rows.Clear();

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

        //Построение графика за 15 лет
        private void Build_Chart()
        {
            //Очистка графика
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add("Chart");

            //Перебор по колонкам таблицы
            foreach (DataGridViewColumn column in Expenses_dataGridView.Columns)
            {
                if (column.Index != 0)
                {
                    Series series = new Series(column.HeaderText);
                    series.ChartType = SeriesChartType.Line; //Тип графика - линейный
                    series.BorderWidth = 3;

                    //Построение графика
                    int rows_count = Expenses_dataGridView.Rows.Count - 1;
                    for (int i = 0; i < rows_count; i++)
                    {
                        string year = Expenses_dataGridView.Rows[i].Cells[0].Value.ToString();
                        int value = Convert.ToInt32(Expenses_dataGridView.Rows[i].Cells[column.Index].Value);
                        series.Points.AddXY(year, value);
                    }
                    chart1.Series.Add(series);
                }

                
            }
        }

        private void Expenses_openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        //Открытие таблицы и построение графика по ней
        private void Open_expenses_button_Click(object sender, EventArgs e)
        {
            Load_to_Form();
            Build_Chart();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}