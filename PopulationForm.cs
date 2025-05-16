using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TP_Lab3 {
    public partial class PopulationForm : Form {
        public PopulationForm()
        {
            InitializeComponent();
        }
        private void LoadIntoGrid(string path)
        {
            var lines = File.ReadAllLines(path);
            if (lines.Length > 0)
            {
                var headers = lines[0].Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                //добавляем все столбцы, кроме первого (он станет заголовком строки)
                for (int i = 1; i < headers.Length; i++)
                {
                    PopylationGrid.Columns.Add(headers[i], headers[i]);
                }

                foreach (var line in lines.Skip(1))
                {
                    var values = line.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    if (values.Length == headers.Length)
                    {
                        //добавляем строку без первого значения
                        var rowIndex = PopylationGrid.Rows.Add(values.Skip(1).ToArray());

                        //значение первого столбца в RowHeader
                        PopylationGrid.Rows[rowIndex].HeaderCell.Value = values[0];
                    }
                }

                //ширина заголовка
                PopylationGrid.RowHeadersWidth = 75;
            }
        }
        private void GetRegionWithMaxOrMinReductionPopulation(DataGridView PopylationGrid, out string regionWithMaxReduction, out string regionWithMinReduction)
        {
            regionWithMaxReduction = "Нет данных";
            regionWithMinReduction = "Нет данных";
            double maxReduction = double.MinValue;
            double minReduction = double.MaxValue;
            for (int col = 0; col < PopylationGrid.ColumnCount; col++)
            {
                string regionName = PopylationGrid.Columns[col].HeaderText;

                //берем значения за первый и последний год
                if (double.TryParse(PopylationGrid.Rows[0].Cells[col].Value?.ToString(), out double firstYearValue) &&
                    double.TryParse(PopylationGrid.Rows[PopylationGrid.RowCount - 2].Cells[col].Value?.ToString(), out double lastYearValue))
                {
                    double reduction = firstYearValue - lastYearValue;
                    if (reduction > 0)
                    {
                        if (reduction > maxReduction)
                        {
                            maxReduction = reduction;
                            regionWithMaxReduction = regionName;
                        }
                        if (reduction < minReduction)
                        {
                            minReduction = reduction;
                            regionWithMinReduction = regionName;
                        }
                    }
                }
            }
        }
        private void LoadDataInComboBox(ComboBox comboBox, DataGridView dataGridView) 
        {
            for (int col = 0; col <= dataGridView.ColumnCount - 1; col++)
            {
                if (dataGridView.Rows[0].Cells[col].Value == null) return;
                comboBox.Items.Add(dataGridView.Columns[col].HeaderCell.Value.ToString());
            }
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files(*.TXT)|*.TXT|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LoadIntoGrid(ofd.FileName);
                    GetRegionWithMaxOrMinReductionPopulation(PopylationGrid, out string regionWithMaxReduction, out string regionWithMinReduction);
                    labelMaxReductionPopulation.Text += regionWithMaxReduction;
                    labelMinReductionPopulation.Text += regionWithMinReduction;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadDataInComboBox(comboBoxSelectRegion, PopylationGrid);
            }
        }
        private void AddChartPopulation(string region)
        {
            chartPopularion.ChartAreas.Clear();
            chartPopularion.Series.Clear();
            chartPopularion.ChartAreas.Add(new ChartArea());
            int regNum = -1;
            Series mainSeries = new Series()
            {
                ChartType = SeriesChartType.Line,
                BorderColor = Color.Green,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 3,
                //IsValueShownAsLabel = true
            };
            //находим среди хеддера нужный индекс нужного региона
            for (int col = 0; col < PopylationGrid.ColumnCount; col++)
            {
                if (PopylationGrid.Columns[col].HeaderText == region)
                {
                    regNum = col; break;
                }
            }
            if (regNum == -1)
            {
                MessageBox.Show("Регион не найден в таблице.");
                return;
            }
            //Добавляем график
            for (int row = 0; row < PopylationGrid.RowCount; row++)
            {
                var yearCell = PopylationGrid.Rows[row].HeaderCell.Value?.ToString();
                var valueCell = PopylationGrid.Rows[row].Cells[regNum].Value?.ToString();

                if (int.TryParse(yearCell, out int year) && double.TryParse(valueCell, out double population))
                {
                    mainSeries.Points.AddXY(year, population);
                }
            }

            //mainSeries.Points.AddXY();
            chartPopularion.Series.Add(mainSeries);
            chartPopularion.ChartAreas[0].AxisX.Title = "Год";
            chartPopularion.ChartAreas[0].AxisY.Title = "Численность населения";
            chartPopularion.Titles.Clear();
            chartPopularion.Titles.Add("График зависимости численности населения от года");
            chartPopularion.Legends.Clear();
        }
        private void buttonPredictPopulation_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectRegion.Items.Count < 0) return;
            AddChartPopulation(comboBoxSelectRegion.Text);
        }

        private void buttonForecastPopulation_Click(object sender, EventArgs e)
        {

        }
    }
}
