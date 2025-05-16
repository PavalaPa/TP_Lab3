namespace TP_Lab3
{
    partial class Consumer_spending_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Expenses_dataGridView = new System.Windows.Forms.DataGridView();
            this.Open_expenses_button = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Expenses_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Min_max_comboBox = new System.Windows.Forms.ComboBox();
            this.Min_max_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.Predict_button = new System.Windows.Forms.Button();
            this.N_numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Expenses_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Expenses_dataGridView
            // 
            this.Expenses_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Expenses_dataGridView.Location = new System.Drawing.Point(21, 17);
            this.Expenses_dataGridView.Name = "Expenses_dataGridView";
            this.Expenses_dataGridView.RowHeadersWidth = 51;
            this.Expenses_dataGridView.RowTemplate.Height = 24;
            this.Expenses_dataGridView.Size = new System.Drawing.Size(348, 290);
            this.Expenses_dataGridView.TabIndex = 0;
            // 
            // Open_expenses_button
            // 
            this.Open_expenses_button.Location = new System.Drawing.Point(103, 328);
            this.Open_expenses_button.Name = "Open_expenses_button";
            this.Open_expenses_button.Size = new System.Drawing.Size(162, 58);
            this.Open_expenses_button.TabIndex = 1;
            this.Open_expenses_button.Text = "Загрузить данные";
            this.Open_expenses_button.UseVisualStyleBackColor = true;
            this.Open_expenses_button.Click += new System.EventHandler(this.Open_expenses_button_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(411, 17);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(687, 290);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // Min_max_comboBox
            // 
            this.Min_max_comboBox.FormattingEnabled = true;
            this.Min_max_comboBox.Location = new System.Drawing.Point(103, 433);
            this.Min_max_comboBox.Name = "Min_max_comboBox";
            this.Min_max_comboBox.Size = new System.Drawing.Size(162, 24);
            this.Min_max_comboBox.TabIndex = 3;
            // 
            // Min_max_button
            // 
            this.Min_max_button.Location = new System.Drawing.Point(103, 473);
            this.Min_max_button.Name = "Min_max_button";
            this.Min_max_button.Size = new System.Drawing.Size(161, 52);
            this.Min_max_button.TabIndex = 4;
            this.Min_max_button.Text = "Поиск";
            this.Min_max_button.UseVisualStyleBackColor = true;
            this.Min_max_button.Click += new System.EventHandler(this.Min_max_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Поиск минимальной и максимальной разницы";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(410, 334);
            this.chart2.Name = "chart2";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(687, 324);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chart2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 542);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Спрогнозировать расходы на N лет";
            // 
            // Predict_button
            // 
            this.Predict_button.Location = new System.Drawing.Point(104, 615);
            this.Predict_button.Name = "Predict_button";
            this.Predict_button.Size = new System.Drawing.Size(161, 62);
            this.Predict_button.TabIndex = 9;
            this.Predict_button.Text = "Показать прогнозы";
            this.Predict_button.UseVisualStyleBackColor = true;
            this.Predict_button.Click += new System.EventHandler(this.Predict_button_Click);
            // 
            // N_numericUpDown
            // 
            this.N_numericUpDown.Location = new System.Drawing.Point(129, 575);
            this.N_numericUpDown.Name = "N_numericUpDown";
            this.N_numericUpDown.Size = new System.Drawing.Size(120, 22);
            this.N_numericUpDown.TabIndex = 10;
            // 
            // Consumer_spending_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 737);
            this.Controls.Add(this.N_numericUpDown);
            this.Controls.Add(this.Predict_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Min_max_button);
            this.Controls.Add(this.Min_max_comboBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Open_expenses_button);
            this.Controls.Add(this.Expenses_dataGridView);
            this.Name = "Consumer_spending_Form";
            this.Text = "Consumer_spending_Form";
            ((System.ComponentModel.ISupportInitialize)(this.Expenses_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Expenses_dataGridView;
        private System.Windows.Forms.Button Open_expenses_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.OpenFileDialog Expenses_openFileDialog;
        private System.Windows.Forms.ComboBox Min_max_comboBox;
        private System.Windows.Forms.Button Min_max_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Predict_button;
        private System.Windows.Forms.NumericUpDown N_numericUpDown;
    }
}