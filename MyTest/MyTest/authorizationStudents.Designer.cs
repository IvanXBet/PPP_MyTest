namespace MyTest
{
    partial class authorizationStudents
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
            this.components = new System.ComponentModel.Container();
            this.labelNameFormStud = new System.Windows.Forms.Label();
            this.labelInputGroupStud = new System.Windows.Forms.Label();
            this.labelInputLoginStud = new System.Windows.Forms.Label();
            this.textBoxLoginStud = new System.Windows.Forms.TextBox();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.buttonSingin = new System.Windows.Forms.Button();
            this.comboBoxGroupStud = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myTestDataSet = new MyTest.MyTestDataSet();
            this.teamsTableAdapter = new MyTest.MyTestDataSetTableAdapters.TeamsTableAdapter();
            this.studentsTableAdapter1 = new MyTest.MyTestDataSetTableAdapters.StudentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTestDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameFormStud
            // 
            this.labelNameFormStud.AutoSize = true;
            this.labelNameFormStud.Font = new System.Drawing.Font("Yu Gothic UI Light", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameFormStud.ForeColor = System.Drawing.Color.Linen;
            this.labelNameFormStud.Location = new System.Drawing.Point(235, 124);
            this.labelNameFormStud.Name = "labelNameFormStud";
            this.labelNameFormStud.Size = new System.Drawing.Size(177, 38);
            this.labelNameFormStud.TabIndex = 11;
            this.labelNameFormStud.Text = "Авторизация";
            this.labelNameFormStud.Click += new System.EventHandler(this.labelNameFormStud_Click);
            // 
            // labelInputGroupStud
            // 
            this.labelInputGroupStud.AutoSize = true;
            this.labelInputGroupStud.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 14F);
            this.labelInputGroupStud.ForeColor = System.Drawing.Color.Linen;
            this.labelInputGroupStud.Location = new System.Drawing.Point(54, 240);
            this.labelInputGroupStud.Name = "labelInputGroupStud";
            this.labelInputGroupStud.Size = new System.Drawing.Size(159, 25);
            this.labelInputGroupStud.TabIndex = 16;
            this.labelInputGroupStud.Text = "Выберите группу";
            // 
            // labelInputLoginStud
            // 
            this.labelInputLoginStud.AutoSize = true;
            this.labelInputLoginStud.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 14F);
            this.labelInputLoginStud.ForeColor = System.Drawing.Color.Linen;
            this.labelInputLoginStud.Location = new System.Drawing.Point(85, 196);
            this.labelInputLoginStud.Name = "labelInputLoginStud";
            this.labelInputLoginStud.Size = new System.Drawing.Size(128, 25);
            this.labelInputLoginStud.TabIndex = 15;
            this.labelInputLoginStud.Text = "Ведаите ФИО";
            // 
            // textBoxLoginStud
            // 
            this.textBoxLoginStud.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxLoginStud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoginStud.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 20F);
            this.textBoxLoginStud.Location = new System.Drawing.Point(242, 190);
            this.textBoxLoginStud.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxLoginStud.MaxLength = 50;
            this.textBoxLoginStud.Name = "textBoxLoginStud";
            this.textBoxLoginStud.Size = new System.Drawing.Size(288, 36);
            this.textBoxLoginStud.TabIndex = 13;
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.BackColor = System.Drawing.Color.Orange;
            this.buttonRegistration.FlatAppearance.BorderSize = 0;
            this.buttonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistration.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.buttonRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.buttonRegistration.Location = new System.Drawing.Point(325, 296);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(205, 37);
            this.buttonRegistration.TabIndex = 18;
            this.buttonRegistration.Text = "Вход";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // buttonSingin
            // 
            this.buttonSingin.BackColor = System.Drawing.Color.Orange;
            this.buttonSingin.FlatAppearance.BorderSize = 0;
            this.buttonSingin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSingin.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.buttonSingin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.buttonSingin.Location = new System.Drawing.Point(242, 296);
            this.buttonSingin.Name = "buttonSingin";
            this.buttonSingin.Size = new System.Drawing.Size(77, 37);
            this.buttonSingin.TabIndex = 17;
            this.buttonSingin.Text = "Отмена";
            this.buttonSingin.UseVisualStyleBackColor = false;
            this.buttonSingin.Click += new System.EventHandler(this.buttonSingin_Click);
            // 
            // comboBoxGroupStud
            // 
            this.comboBoxGroupStud.DataSource = this.teamsBindingSource;
            this.comboBoxGroupStud.DisplayMember = "Team";
            this.comboBoxGroupStud.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 14F);
            this.comboBoxGroupStud.FormattingEnabled = true;
            this.comboBoxGroupStud.Location = new System.Drawing.Point(242, 240);
            this.comboBoxGroupStud.Name = "comboBoxGroupStud";
            this.comboBoxGroupStud.Size = new System.Drawing.Size(288, 33);
            this.comboBoxGroupStud.TabIndex = 19;
            this.comboBoxGroupStud.ValueMember = "ID_team";
            this.comboBoxGroupStud.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroupStud_SelectedIndexChanged);
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "Teams";
            this.teamsBindingSource.DataSource = this.myTestDataSet;
            // 
            // myTestDataSet
            // 
            this.myTestDataSet.DataSetName = "MyTestDataSet";
            this.myTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter1
            // 
            this.studentsTableAdapter1.ClearBeforeFill = true;
            // 
            // authorizationStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(724, 461);
            this.Controls.Add(this.comboBoxGroupStud);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.buttonSingin);
            this.Controls.Add(this.labelInputGroupStud);
            this.Controls.Add(this.labelInputLoginStud);
            this.Controls.Add(this.textBoxLoginStud);
            this.Controls.Add(this.labelNameFormStud);
            this.MaximumSize = new System.Drawing.Size(740, 500);
            this.MinimumSize = new System.Drawing.Size(740, 500);
            this.Name = "authorizationStudents";
            this.Text = "Авторизация студента";
            this.Load += new System.EventHandler(this.authorizationStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTestDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameFormStud;
        private System.Windows.Forms.Label labelInputGroupStud;
        private System.Windows.Forms.Label labelInputLoginStud;
        private System.Windows.Forms.TextBox textBoxLoginStud;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Button buttonSingin;
        private System.Windows.Forms.ComboBox comboBoxGroupStud;
        private MyTestDataSet myTestDataSet;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private MyTestDataSetTableAdapters.TeamsTableAdapter teamsTableAdapter;
        private MyTestDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter1;
    }
}