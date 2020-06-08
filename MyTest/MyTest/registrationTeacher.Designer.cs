namespace MyTest
{
    partial class registrationTeacher
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
            this.labelNameRegistrationTeacher = new System.Windows.Forms.Label();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelnewLogin = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewLogin = new System.Windows.Forms.TextBox();
            this.textBoxRepeatPassword = new System.Windows.Forms.TextBox();
            this.labelRepeatPassword = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSingin = new System.Windows.Forms.Button();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.labelNewName = new System.Windows.Forms.Label();
            this.teachersTableAdapter1 = new MyTest.MyTestDataSetTableAdapters.TeachersTableAdapter();
            this.SuspendLayout();
            // 
            // labelNameRegistrationTeacher
            // 
            this.labelNameRegistrationTeacher.AutoSize = true;
            this.labelNameRegistrationTeacher.Font = new System.Drawing.Font("Yu Gothic UI Light", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameRegistrationTeacher.ForeColor = System.Drawing.Color.Linen;
            this.labelNameRegistrationTeacher.Location = new System.Drawing.Point(207, 30);
            this.labelNameRegistrationTeacher.Name = "labelNameRegistrationTeacher";
            this.labelNameRegistrationTeacher.Size = new System.Drawing.Size(167, 38);
            this.labelNameRegistrationTeacher.TabIndex = 11;
            this.labelNameRegistrationTeacher.Text = "Регистрация";
            this.labelNameRegistrationTeacher.Click += new System.EventHandler(this.labelNameRegistrationTeacher_Click);
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Font = new System.Drawing.Font("Yu Gothic UI Light", 14F);
            this.labelNewPassword.ForeColor = System.Drawing.Color.Linen;
            this.labelNewPassword.Location = new System.Drawing.Point(119, 164);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(178, 25);
            this.labelNewPassword.TabIndex = 20;
            this.labelNewPassword.Text = "Придумайте пароль";
            this.labelNewPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelnewLogin
            // 
            this.labelnewLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelnewLogin.AutoSize = true;
            this.labelnewLogin.Font = new System.Drawing.Font("Yu Gothic UI Light", 14F);
            this.labelnewLogin.ForeColor = System.Drawing.Color.Linen;
            this.labelnewLogin.Location = new System.Drawing.Point(164, 112);
            this.labelnewLogin.Name = "labelnewLogin";
            this.labelnewLogin.Size = new System.Drawing.Size(130, 25);
            this.labelnewLogin.TabIndex = 18;
            this.labelnewLogin.Text = "Введите логин";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.BackColor = System.Drawing.Color.Linen;
            this.textBoxNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxNewPassword.Location = new System.Drawing.Point(338, 164);
            this.textBoxNewPassword.MaxLength = 20;
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(238, 31);
            this.textBoxNewPassword.TabIndex = 22;
            // 
            // textBoxNewLogin
            // 
            this.textBoxNewLogin.BackColor = System.Drawing.Color.Linen;
            this.textBoxNewLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNewLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxNewLogin.Location = new System.Drawing.Point(338, 112);
            this.textBoxNewLogin.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxNewLogin.MaxLength = 20;
            this.textBoxNewLogin.Name = "textBoxNewLogin";
            this.textBoxNewLogin.Size = new System.Drawing.Size(238, 31);
            this.textBoxNewLogin.TabIndex = 21;
            // 
            // textBoxRepeatPassword
            // 
            this.textBoxRepeatPassword.BackColor = System.Drawing.Color.Linen;
            this.textBoxRepeatPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRepeatPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxRepeatPassword.Location = new System.Drawing.Point(338, 220);
            this.textBoxRepeatPassword.MaxLength = 20;
            this.textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            this.textBoxRepeatPassword.PasswordChar = '*';
            this.textBoxRepeatPassword.Size = new System.Drawing.Size(238, 31);
            this.textBoxRepeatPassword.TabIndex = 24;
            // 
            // labelRepeatPassword
            // 
            this.labelRepeatPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRepeatPassword.AutoSize = true;
            this.labelRepeatPassword.Font = new System.Drawing.Font("Yu Gothic UI Light", 14F);
            this.labelRepeatPassword.ForeColor = System.Drawing.Color.Linen;
            this.labelRepeatPassword.Location = new System.Drawing.Point(128, 220);
            this.labelRepeatPassword.Name = "labelRepeatPassword";
            this.labelRepeatPassword.Size = new System.Drawing.Size(166, 25);
            this.labelRepeatPassword.TabIndex = 23;
            this.labelRepeatPassword.Text = "Повторите пароль";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Orange;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(397, 336);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(119, 42);
            this.buttonBack.TabIndex = 26;
            this.buttonBack.Text = "Отмена";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSingin
            // 
            this.buttonSingin.BackColor = System.Drawing.Color.Orange;
            this.buttonSingin.FlatAppearance.BorderSize = 0;
            this.buttonSingin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSingin.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.buttonSingin.ForeColor = System.Drawing.Color.White;
            this.buttonSingin.Location = new System.Drawing.Point(173, 336);
            this.buttonSingin.Name = "buttonSingin";
            this.buttonSingin.Size = new System.Drawing.Size(201, 42);
            this.buttonSingin.TabIndex = 25;
            this.buttonSingin.Text = "Зарегистрироваться ";
            this.buttonSingin.UseVisualStyleBackColor = false;
            this.buttonSingin.Click += new System.EventHandler(this.buttonSingin_Click);
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.BackColor = System.Drawing.Color.Linen;
            this.textBoxNewName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxNewName.Location = new System.Drawing.Point(338, 273);
            this.textBoxNewName.MaxLength = 20;
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(238, 31);
            this.textBoxNewName.TabIndex = 28;
            // 
            // labelNewName
            // 
            this.labelNewName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNewName.AutoSize = true;
            this.labelNewName.Font = new System.Drawing.Font("Yu Gothic UI Light", 14F);
            this.labelNewName.ForeColor = System.Drawing.Color.Linen;
            this.labelNewName.Location = new System.Drawing.Point(180, 279);
            this.labelNewName.Name = "labelNewName";
            this.labelNewName.Size = new System.Drawing.Size(114, 25);
            this.labelNewName.TabIndex = 27;
            this.labelNewName.Text = "Введите имя";
            // 
            // teachersTableAdapter1
            // 
            this.teachersTableAdapter1.ClearBeforeFill = true;
            // 
            // registrationTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(729, 420);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.labelNewName);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSingin);
            this.Controls.Add(this.textBoxRepeatPassword);
            this.Controls.Add(this.labelRepeatPassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.textBoxNewLogin);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.labelnewLogin);
            this.Controls.Add(this.labelNameRegistrationTeacher);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(745, 459);
            this.Name = "registrationTeacher";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameRegistrationTeacher;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Label labelnewLogin;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxNewLogin;
        private System.Windows.Forms.TextBox textBoxRepeatPassword;
        private System.Windows.Forms.Label labelRepeatPassword;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSingin;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label labelNewName;
        private MyTestDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter1;
    }
}