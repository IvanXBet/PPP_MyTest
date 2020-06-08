namespace MyTest
{
    partial class FirstForm
    {
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
            this.buttonWorkWithText = new System.Windows.Forms.Button();
            this.buttonPassingTest = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelNameFirstForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonWorkWithText
            // 
            this.buttonWorkWithText.BackColor = System.Drawing.Color.Orange;
            this.buttonWorkWithText.FlatAppearance.BorderSize = 0;
            this.buttonWorkWithText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorkWithText.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.buttonWorkWithText.ForeColor = System.Drawing.Color.White;
            this.buttonWorkWithText.Location = new System.Drawing.Point(92, 97);
            this.buttonWorkWithText.Name = "buttonWorkWithText";
            this.buttonWorkWithText.Size = new System.Drawing.Size(211, 53);
            this.buttonWorkWithText.TabIndex = 0;
            this.buttonWorkWithText.Text = "Работа с текстом";
            this.buttonWorkWithText.UseVisualStyleBackColor = false;
            this.buttonWorkWithText.Click += new System.EventHandler(this.buttonWorkWithText_Click);
            // 
            // buttonPassingTest
            // 
            this.buttonPassingTest.BackColor = System.Drawing.Color.Orange;
            this.buttonPassingTest.FlatAppearance.BorderSize = 0;
            this.buttonPassingTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPassingTest.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.buttonPassingTest.ForeColor = System.Drawing.Color.White;
            this.buttonPassingTest.Location = new System.Drawing.Point(92, 170);
            this.buttonPassingTest.Name = "buttonPassingTest";
            this.buttonPassingTest.Size = new System.Drawing.Size(211, 50);
            this.buttonPassingTest.TabIndex = 1;
            this.buttonPassingTest.Text = "Прохождение теста";
            this.buttonPassingTest.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Orange;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(92, 245);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(211, 47);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выход из приложения";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // labelNameFirstForm
            // 
            this.labelNameFirstForm.AutoSize = true;
            this.labelNameFirstForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNameFirstForm.Font = new System.Drawing.Font("Yu Gothic UI Light", 21F);
            this.labelNameFirstForm.ForeColor = System.Drawing.Color.White;
            this.labelNameFirstForm.Location = new System.Drawing.Point(86, 30);
            this.labelNameFirstForm.Name = "labelNameFirstForm";
            this.labelNameFirstForm.Size = new System.Drawing.Size(102, 38);
            this.labelNameFirstForm.TabIndex = 3;
            this.labelNameFirstForm.Text = "My test";
            this.labelNameFirstForm.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(371, 339);
            this.Controls.Add(this.labelNameFirstForm);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPassingTest);
            this.Controls.Add(this.buttonWorkWithText);
            this.MinimumSize = new System.Drawing.Size(387, 378);
            this.Name = "FirstForm";
            this.Text = "Главное меню приложения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWorkWithText;
        private System.Windows.Forms.Button buttonPassingTest;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelNameFirstForm;
    }
}

