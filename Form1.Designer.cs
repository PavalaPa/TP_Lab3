﻿namespace TP_Lab3 {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Consumer_spending_button = new System.Windows.Forms.Button();
            this.buttonPopulation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Consumer_spending_button
            // 
            this.Consumer_spending_button.BackColor = System.Drawing.Color.SteelBlue;
            this.Consumer_spending_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.98507F);
            this.Consumer_spending_button.Location = new System.Drawing.Point(309, 240);
            this.Consumer_spending_button.Name = "Consumer_spending_button";
            this.Consumer_spending_button.Size = new System.Drawing.Size(188, 117);
            this.Consumer_spending_button.TabIndex = 0;
            this.Consumer_spending_button.Text = "Посмотреть расходы пользователя";
            this.Consumer_spending_button.UseVisualStyleBackColor = false;
            this.Consumer_spending_button.Click += new System.EventHandler(this.Consumer_spending_button_Click);
            // 
            // buttonPopulation
            // 
            this.buttonPopulation.BackColor = System.Drawing.Color.Sienna;
            this.buttonPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.98507F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPopulation.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPopulation.Location = new System.Drawing.Point(309, 39);
            this.buttonPopulation.Name = "buttonPopulation";
            this.buttonPopulation.Size = new System.Drawing.Size(188, 117);
            this.buttonPopulation.TabIndex = 0;
            this.buttonPopulation.Text = "Посмотреть численность населения";
            this.buttonPopulation.UseVisualStyleBackColor = false;
            this.buttonPopulation.Click += new System.EventHandler(this.buttonPopulation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Consumer_spending_button);
            this.Controls.Add(this.buttonPopulation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Consumer_spending_button;
        private System.Windows.Forms.Button buttonPopulation;

    }
}

