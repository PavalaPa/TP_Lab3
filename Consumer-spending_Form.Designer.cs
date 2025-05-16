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
            this.Expenses_dataGridView = new System.Windows.Forms.DataGridView();
            this.Open_expenses_button = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Expenses_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Expenses_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.Open_expenses_button.Location = new System.Drawing.Point(21, 353);
            this.Open_expenses_button.Name = "Open_expenses_button";
            this.Open_expenses_button.Size = new System.Drawing.Size(162, 85);
            this.Open_expenses_button.TabIndex = 1;
            this.Open_expenses_button.Text = "button1";
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
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Expenses_openFileDialog
            // 
            this.Expenses_openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.Expenses_openFileDialog_FileOk);
            // 
            // Consumer_spending_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Open_expenses_button);
            this.Controls.Add(this.Expenses_dataGridView);
            this.Name = "Consumer_spending_Form";
            this.Text = "Consumer_spending_Form";
            ((System.ComponentModel.ISupportInitialize)(this.Expenses_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Expenses_dataGridView;
        private System.Windows.Forms.Button Open_expenses_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.OpenFileDialog Expenses_openFileDialog;
    }
}