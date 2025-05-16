namespace TP_Lab3 {
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
            this.SuspendLayout();
            // 
            // Consumer_spending_button
            // 
            this.Consumer_spending_button.Location = new System.Drawing.Point(263, 266);
            this.Consumer_spending_button.Name = "Consumer_spending_button";
            this.Consumer_spending_button.Size = new System.Drawing.Size(255, 105);
            this.Consumer_spending_button.TabIndex = 0;
            this.Consumer_spending_button.Text = "Consumer spending";
            this.Consumer_spending_button.UseVisualStyleBackColor = true;
            this.Consumer_spending_button.Click += new System.EventHandler(this.Consumer_spending_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Consumer_spending_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Consumer_spending_button;
    }
}

