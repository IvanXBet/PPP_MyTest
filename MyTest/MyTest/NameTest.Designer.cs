namespace MyTest
{
    partial class NameTest
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
            this.textBoxNameTest = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelNameTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNameTest
            // 
            this.textBoxNameTest.Location = new System.Drawing.Point(272, 89);
            this.textBoxNameTest.Name = "textBoxNameTest";
            this.textBoxNameTest.Size = new System.Drawing.Size(166, 20);
            this.textBoxNameTest.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Orange;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.buttonBack.Location = new System.Drawing.Point(138, 182);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(84, 33);
            this.buttonBack.TabIndex = 28;
            this.buttonBack.Text = "Отмена";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Orange;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.buttonOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.buttonOK.Location = new System.Drawing.Point(250, 182);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(166, 33);
            this.buttonOK.TabIndex = 27;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelNameTest
            // 
            this.labelNameTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNameTest.AutoSize = true;
            this.labelNameTest.Font = new System.Drawing.Font("Yu Gothic UI Light", 14F);
            this.labelNameTest.ForeColor = System.Drawing.Color.Linen;
            this.labelNameTest.Location = new System.Drawing.Point(35, 83);
            this.labelNameTest.Name = "labelNameTest";
            this.labelNameTest.Size = new System.Drawing.Size(205, 25);
            this.labelNameTest.TabIndex = 29;
            this.labelNameTest.Text = "Введите название теста";
            // 
            // NameTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(527, 284);
            this.Controls.Add(this.labelNameTest);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxNameTest);
            this.Name = "NameTest";
            this.Text = "NameTest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NameTest_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameTest;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelNameTest;
    }
}