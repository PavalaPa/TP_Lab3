namespace TP_Lab3 {
    partial class PopulationForm {
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.PopylationGrid = new System.Windows.Forms.DataGridView();
            this.chartPopularion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelMaxReductionPopulation = new System.Windows.Forms.Label();
            this.labelMinReductionPopulation = new System.Windows.Forms.Label();
            this.buttonPredictPopulation = new System.Windows.Forms.Button();
            this.numericUpDownPredict = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PopylationGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPopularion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPredict)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.985074F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile.Location = new System.Drawing.Point(30, 32);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(145, 36);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // PopylationGrid
            // 
            this.PopylationGrid.BackgroundColor = System.Drawing.Color.Azure;
            this.PopylationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PopylationGrid.Location = new System.Drawing.Point(30, 74);
            this.PopylationGrid.Name = "PopylationGrid";
            this.PopylationGrid.RowHeadersWidth = 57;
            this.PopylationGrid.RowTemplate.Height = 24;
            this.PopylationGrid.Size = new System.Drawing.Size(346, 301);
            this.PopylationGrid.TabIndex = 1;
            // 
            // chartPopularion
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPopularion.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPopularion.Legends.Add(legend2);
            this.chartPopularion.Location = new System.Drawing.Point(415, 75);
            this.chartPopularion.Name = "chartPopularion";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartPopularion.Series.Add(series2);
            this.chartPopularion.Size = new System.Drawing.Size(493, 300);
            this.chartPopularion.TabIndex = 2;
            this.chartPopularion.Text = "chart1";
            // 
            // labelMaxReductionPopulation
            // 
            this.labelMaxReductionPopulation.AutoSize = true;
            this.labelMaxReductionPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.985074F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxReductionPopulation.Location = new System.Drawing.Point(27, 394);
            this.labelMaxReductionPopulation.Name = "labelMaxReductionPopulation";
            this.labelMaxReductionPopulation.Size = new System.Drawing.Size(609, 20);
            this.labelMaxReductionPopulation.TabIndex = 3;
            this.labelMaxReductionPopulation.Text = "За поледние 15 лет численность снизилась больше всего в субъекте: ";
            // 
            // labelMinReductionPopulation
            // 
            this.labelMinReductionPopulation.AutoSize = true;
            this.labelMinReductionPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.985074F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinReductionPopulation.Location = new System.Drawing.Point(27, 429);
            this.labelMinReductionPopulation.Name = "labelMinReductionPopulation";
            this.labelMinReductionPopulation.Size = new System.Drawing.Size(611, 20);
            this.labelMinReductionPopulation.TabIndex = 4;
            this.labelMinReductionPopulation.Text = "За поледние 15 лет численность снизилась меньше всего в субъекте: ";
            // 
            // buttonPredictPopulation
            // 
            this.buttonPredictPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.985074F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPredictPopulation.Location = new System.Drawing.Point(415, 32);
            this.buttonPredictPopulation.Name = "buttonPredictPopulation";
            this.buttonPredictPopulation.Size = new System.Drawing.Size(184, 36);
            this.buttonPredictPopulation.TabIndex = 5;
            this.buttonPredictPopulation.Text = "Прогнозировать на";
            this.buttonPredictPopulation.UseVisualStyleBackColor = true;
            this.buttonPredictPopulation.Click += new System.EventHandler(this.buttonPredictPopulation_Click);
            // 
            // numericUpDownPredict
            // 
            this.numericUpDownPredict.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.98507F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownPredict.Location = new System.Drawing.Point(605, 33);
            this.numericUpDownPredict.Name = "numericUpDownPredict";
            this.numericUpDownPredict.Size = new System.Drawing.Size(110, 33);
            this.numericUpDownPredict.TabIndex = 6;
            // 
            // PopulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(960, 466);
            this.Controls.Add(this.numericUpDownPredict);
            this.Controls.Add(this.buttonPredictPopulation);
            this.Controls.Add(this.labelMinReductionPopulation);
            this.Controls.Add(this.labelMaxReductionPopulation);
            this.Controls.Add(this.chartPopularion);
            this.Controls.Add(this.PopylationGrid);
            this.Controls.Add(this.buttonOpenFile);
            this.Name = "PopulationForm";
            this.Text = "PopulationForm";
            ((System.ComponentModel.ISupportInitialize)(this.PopylationGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPopularion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPredict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.DataGridView PopylationGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPopularion;
        private System.Windows.Forms.Label labelMaxReductionPopulation;
        private System.Windows.Forms.Label labelMinReductionPopulation;
        private System.Windows.Forms.Button buttonPredictPopulation;
        private System.Windows.Forms.NumericUpDown numericUpDownPredict;
    }
}