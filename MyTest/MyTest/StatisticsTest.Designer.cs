namespace MyTest
{
    partial class StatisticsTest
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
            this.labelSelectSelectionBias = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelResults = new System.Windows.Forms.Label();
            this.myTestDataSet1 = new MyTest.MyTestDataSet();
            this.statisticsTableAdapter1 = new MyTest.MyTestDataSetTableAdapters.StatisticsTableAdapter();
            this.textBoxNameStudent = new System.Windows.Forms.TextBox();
            this.buttonAddAnswer = new System.Windows.Forms.Button();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamsTableAdapter = new MyTest.MyTestDataSetTableAdapters.TeamsTableAdapter();
            this.comboBoxNameTest = new System.Windows.Forms.ComboBox();
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testsTableAdapter = new MyTest.MyTestDataSetTableAdapters.TestsTableAdapter();
            this.myTestDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFinish = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownMark = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTestDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTestDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMark)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelectSelectionBias
            // 
            this.labelSelectSelectionBias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectSelectionBias.AutoSize = true;
            this.labelSelectSelectionBias.Font = new System.Drawing.Font("Yu Gothic UI Light", 14F);
            this.labelSelectSelectionBias.ForeColor = System.Drawing.Color.Linen;
            this.labelSelectSelectionBias.Location = new System.Drawing.Point(26, 27);
            this.labelSelectSelectionBias.Name = "labelSelectSelectionBias";
            this.labelSelectSelectionBias.Size = new System.Drawing.Size(238, 25);
            this.labelSelectSelectionBias.TabIndex = 32;
            this.labelSelectSelectionBias.Text = "Выберите критерий отбора";
            // 
            // comboBox
            // 
            this.comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Показать все результаты",
            "Поиск студентов по ФИО",
            "Отобрать по группе",
            "Отобрать по названию теста",
            "Фильтрация по интервалу дат",
            "Отбор по оценке"});
            this.comboBox.Location = new System.Drawing.Point(285, 31);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(222, 21);
            this.comboBox.TabIndex = 33;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(31, 82);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(853, 324);
            this.dataGridView.TabIndex = 34;
            // 
            // labelResults
            // 
            this.labelResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Yu Gothic UI Light", 14F);
            this.labelResults.ForeColor = System.Drawing.Color.Linen;
            this.labelResults.Location = new System.Drawing.Point(26, 432);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(117, 25);
            this.labelResults.TabIndex = 35;
            this.labelResults.Text = "Результатов ";
            // 
            // myTestDataSet1
            // 
            this.myTestDataSet1.DataSetName = "MyTestDataSet";
            this.myTestDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statisticsTableAdapter1
            // 
            this.statisticsTableAdapter1.ClearBeforeFill = true;
            // 
            // textBoxNameStudent
            // 
            this.textBoxNameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxNameStudent.Location = new System.Drawing.Point(555, 31);
            this.textBoxNameStudent.Name = "textBoxNameStudent";
            this.textBoxNameStudent.Size = new System.Drawing.Size(189, 21);
            this.textBoxNameStudent.TabIndex = 36;
            this.textBoxNameStudent.Visible = false;
            // 
            // buttonAddAnswer
            // 
            this.buttonAddAnswer.BackColor = System.Drawing.Color.Orange;
            this.buttonAddAnswer.FlatAppearance.BorderSize = 0;
            this.buttonAddAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAnswer.Font = new System.Drawing.Font("Yu Gothic UI Light", 8F);
            this.buttonAddAnswer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.buttonAddAnswer.Location = new System.Drawing.Point(778, 31);
            this.buttonAddAnswer.Name = "buttonAddAnswer";
            this.buttonAddAnswer.Size = new System.Drawing.Size(77, 21);
            this.buttonAddAnswer.TabIndex = 37;
            this.buttonAddAnswer.Text = "Поиск";
            this.buttonAddAnswer.UseVisualStyleBackColor = false;
            this.buttonAddAnswer.Click += new System.EventHandler(this.buttonAddAnswer_Click);
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.DataSource = this.teamsBindingSource;
            this.comboBoxGroup.DisplayMember = "Team";
            this.comboBoxGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBoxGroup.Location = new System.Drawing.Point(555, 31);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGroup.TabIndex = 38;
            this.comboBoxGroup.ValueMember = "Team";
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "Teams";
            this.teamsBindingSource.DataSource = this.myTestDataSet1;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxNameTest
            // 
            this.comboBoxNameTest.DataSource = this.testsBindingSource;
            this.comboBoxNameTest.DisplayMember = "Name_test";
            this.comboBoxNameTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNameTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBoxNameTest.Location = new System.Drawing.Point(555, 31);
            this.comboBoxNameTest.Name = "comboBoxNameTest";
            this.comboBoxNameTest.Size = new System.Drawing.Size(179, 21);
            this.comboBoxNameTest.TabIndex = 39;
            this.comboBoxNameTest.ValueMember = "Name_test";
            // 
            // testsBindingSource
            // 
            this.testsBindingSource.DataMember = "Tests";
            this.testsBindingSource.DataSource = this.myTestDataSet1;
            // 
            // testsTableAdapter
            // 
            this.testsTableAdapter.ClearBeforeFill = true;
            // 
            // myTestDataSet1BindingSource
            // 
            this.myTestDataSet1BindingSource.DataSource = this.myTestDataSet1;
            this.myTestDataSet1BindingSource.Position = 0;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(524, 32);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerStart.TabIndex = 41;
            // 
            // dateTimePickerFinish
            // 
            this.dateTimePickerFinish.Location = new System.Drawing.Point(652, 32);
            this.dateTimePickerFinish.Name = "dateTimePickerFinish";
            this.dateTimePickerFinish.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerFinish.TabIndex = 42;
            // 
            // numericUpDownMark
            // 
            this.numericUpDownMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.numericUpDownMark.Location = new System.Drawing.Point(555, 31);
            this.numericUpDownMark.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownMark.Name = "numericUpDownMark";
            this.numericUpDownMark.Size = new System.Drawing.Size(46, 21);
            this.numericUpDownMark.TabIndex = 43;
            // 
            // StatisticsTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(914, 507);
            this.Controls.Add(this.numericUpDownMark);
            this.Controls.Add(this.dateTimePickerFinish);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.comboBoxNameTest);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.buttonAddAnswer);
            this.Controls.Add(this.textBoxNameStudent);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.labelSelectSelectionBias);
            this.MaximumSize = new System.Drawing.Size(930, 546);
            this.MinimumSize = new System.Drawing.Size(930, 546);
            this.Name = "StatisticsTest";
            this.Text = "Результат прохождения теста";
            this.Load += new System.EventHandler(this.StatisticsTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTestDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myTestDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectSelectionBias;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelResults;
        private MyTestDataSet myTestDataSet1;
        private MyTestDataSetTableAdapters.StatisticsTableAdapter statisticsTableAdapter1;
        private System.Windows.Forms.TextBox textBoxNameStudent;
        public System.Windows.Forms.Button buttonAddAnswer;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private MyTestDataSetTableAdapters.TeamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxNameTest;
        private System.Windows.Forms.BindingSource testsBindingSource;
        private MyTestDataSetTableAdapters.TestsTableAdapter testsTableAdapter;
        private System.Windows.Forms.BindingSource myTestDataSet1BindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinish;
        private System.Windows.Forms.NumericUpDown numericUpDownMark;
    }
}