namespace MyTest
{
    partial class authorizationTeacher
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
            this.labelInputPassword = new System.Windows.Forms.Label();
            this.labelInputLogin = new System.Windows.Forms.Label();
            this.labelNameForm = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonSingin = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.teachersTableAdapter1 = new MyTest.MyTestDataSetTableAdapters.TeachersTableAdapter();
            this.SuspendLayout();
            // 
            // labelInputPassword
            // 
            this.labelInputPassword.AutoSize = true;
            this.labelInputPassword.Font = new System.Drawing.Font("Yu Gothic UI Light", 14F);
            this.labelInputPassword.ForeColor = System.Drawing.Color.Linen;
            this.labelInputPassword.Location = new System.Drawing.Point(44, 234);
            this.labelInputPassword.Name = "labelInputPassword";
            this.labelInputPassword.Size = new System.Drawing.Size(143, 25);
            this.labelInputPassword.TabIndex = 12;
            this.labelInputPassword.Text = "Введите пароль";
            // 
            // labelInputLogin
            // 
            this.labelInputLogin.AutoSize = true;
            this.labelInputLogin.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 14F);
            this.labelInputLogin.ForeColor = System.Drawing.Color.Linen;
            this.labelInputLogin.Location = new System.Drawing.Point(51, 190);
            this.labelInputLogin.Name = "labelInputLogin";
            this.labelInputLogin.Size = new System.Drawing.Size(136, 25);
            this.labelInputLogin.TabIndex = 11;
            this.labelInputLogin.Text = "Введите логин";
            // 
            // labelNameForm
            // 
            this.labelNameForm.AutoSize = true;
            this.labelNameForm.Font = new System.Drawing.Font("Yu Gothic UI Light", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameForm.ForeColor = System.Drawing.Color.Linen;
            this.labelNameForm.Location = new System.Drawing.Point(207, 112);
            this.labelNameForm.Name = "labelNameForm";
            this.labelNameForm.Size = new System.Drawing.Size(177, 38);
            this.labelNameForm.TabIndex = 10;
            this.labelNameForm.Text = "Авторизация";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.Linen;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxPassword.Location = new System.Drawing.Point(214, 234);
            this.textBoxPassword.MaxLength = 20;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(288, 31);
            this.textBoxPassword.TabIndex = 9;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.Linen;
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxLogin.Location = new System.Drawing.Point(214, 184);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxLogin.MaxLength = 20;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(288, 31);
            this.textBoxLogin.TabIndex = 8;
            // 
            // buttonSingin
            // 
            this.buttonSingin.BackColor = System.Drawing.Color.Orange;
            this.buttonSingin.FlatAppearance.BorderSize = 0;
            this.buttonSingin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSingin.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.buttonSingin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.buttonSingin.Location = new System.Drawing.Point(214, 285);
            this.buttonSingin.Name = "buttonSingin";
            this.buttonSingin.Size = new System.Drawing.Size(141, 42);
            this.buttonSingin.TabIndex = 7;
            this.buttonSingin.Text = "Войти";
            this.buttonSingin.UseVisualStyleBackColor = false;
            this.buttonSingin.Click += new System.EventHandler(this.buttonSingin_Click);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.BackColor = System.Drawing.Color.Orange;
            this.buttonRegistration.FlatAppearance.BorderSize = 0;
            this.buttonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistration.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.buttonRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.buttonRegistration.Location = new System.Drawing.Point(361, 285);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(141, 42);
            this.buttonRegistration.TabIndex = 13;
            this.buttonRegistration.Text = "Регистрация";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // teachersTableAdapter1
            // 
            this.teachersTableAdapter1.ClearBeforeFill = true;
            // 
            // authorizationTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.labelInputPassword);
            this.Controls.Add(this.labelInputLogin);
            this.Controls.Add(this.labelNameForm);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonSingin);
            this.MinimumSize = new System.Drawing.Size(692, 489);
            this.Name = "authorizationTeacher";
            this.Text = "Аторизация преподавателя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInputPassword;
        private System.Windows.Forms.Label labelInputLogin;
        private System.Windows.Forms.Label labelNameForm;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonSingin;
        private System.Windows.Forms.Button buttonRegistration;
        private MyTestDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter1;
    }
}