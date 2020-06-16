namespace MyTest
{
    partial class SelectTest
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelNameFormSelectTest = new System.Windows.Forms.Label();
            this.buttonSelectTest = new System.Windows.Forms.Button();
            this.testTeachersTableAdapter1 = new MyTest.MyTestDataSetTableAdapters.TestTeachersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(48, 100);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(466, 210);
            this.dataGridView.TabIndex = 0;
            // 
            // labelNameFormSelectTest
            // 
            this.labelNameFormSelectTest.AutoSize = true;
            this.labelNameFormSelectTest.Font = new System.Drawing.Font("Yu Gothic UI Light", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameFormSelectTest.ForeColor = System.Drawing.Color.Linen;
            this.labelNameFormSelectTest.Location = new System.Drawing.Point(41, 40);
            this.labelNameFormSelectTest.Name = "labelNameFormSelectTest";
            this.labelNameFormSelectTest.Size = new System.Drawing.Size(334, 38);
            this.labelNameFormSelectTest.TabIndex = 12;
            this.labelNameFormSelectTest.Text = "Выберите тест из таблицы";
            // 
            // buttonSelectTest
            // 
            this.buttonSelectTest.BackColor = System.Drawing.Color.Orange;
            this.buttonSelectTest.FlatAppearance.BorderSize = 0;
            this.buttonSelectTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectTest.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.buttonSelectTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.buttonSelectTest.Location = new System.Drawing.Point(329, 331);
            this.buttonSelectTest.Name = "buttonSelectTest";
            this.buttonSelectTest.Size = new System.Drawing.Size(185, 37);
            this.buttonSelectTest.TabIndex = 19;
            this.buttonSelectTest.Text = "Выбрать";
            this.buttonSelectTest.UseVisualStyleBackColor = false;
            this.buttonSelectTest.Click += new System.EventHandler(this.buttonSelectTest_Click);
            // 
            // testTeachersTableAdapter1
            // 
            this.testTeachersTableAdapter1.ClearBeforeFill = true;
            // 
            // SelectTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(577, 421);
            this.Controls.Add(this.buttonSelectTest);
            this.Controls.Add(this.labelNameFormSelectTest);
            this.Controls.Add(this.dataGridView);
            this.Name = "SelectTest";
            this.Text = "Выбор теста ";
            this.Load += new System.EventHandler(this.SelectTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelNameFormSelectTest;
        private System.Windows.Forms.Button buttonSelectTest;
        private MyTestDataSetTableAdapters.TestTeachersTableAdapter testTeachersTableAdapter1;
    }
}