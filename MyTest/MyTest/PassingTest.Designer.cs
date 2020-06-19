namespace MyTest
{
    partial class PassingTest
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBoxTextQ = new System.Windows.Forms.TextBox();
            this.buttonNextQ = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.teachersTableAdapter1 = new MyTest.MyTestDataSetTableAdapters.TeachersTableAdapter();
            this.resultsTableAdapter1 = new MyTest.MyTestDataSetTableAdapters.ResultsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.buttonNextQ);
            this.splitContainer1.Panel2.Controls.Add(this.button);
            this.splitContainer1.Panel2.Controls.Add(this.progressBar);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1156, 623);
            this.splitContainer1.SplitterDistance = 551;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBoxTextQ);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.splitContainer2.Panel2.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.splitContainer2.Size = new System.Drawing.Size(1156, 551);
            this.splitContainer2.SplitterDistance = 140;
            this.splitContainer2.TabIndex = 0;
            // 
            // textBoxTextQ
            // 
            this.textBoxTextQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTextQ.Font = new System.Drawing.Font("Yu Gothic UI Light", 14F);
            this.textBoxTextQ.Location = new System.Drawing.Point(0, 0);
            this.textBoxTextQ.Multiline = true;
            this.textBoxTextQ.Name = "textBoxTextQ";
            this.textBoxTextQ.Size = new System.Drawing.Size(1156, 140);
            this.textBoxTextQ.TabIndex = 0;
            // 
            // buttonNextQ
            // 
            this.buttonNextQ.BackColor = System.Drawing.Color.Orange;
            this.buttonNextQ.FlatAppearance.BorderSize = 0;
            this.buttonNextQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextQ.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.buttonNextQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.buttonNextQ.Location = new System.Drawing.Point(922, 18);
            this.buttonNextQ.Name = "buttonNextQ";
            this.buttonNextQ.Size = new System.Drawing.Size(188, 37);
            this.buttonNextQ.TabIndex = 21;
            this.buttonNextQ.Text = "Ответить";
            this.buttonNextQ.UseVisualStyleBackColor = false;
            this.buttonNextQ.Click += new System.EventHandler(this.buttonNextQ_Click);
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Yu Gothic UI Light", 12F);
            this.button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.button.Location = new System.Drawing.Point(775, 18);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(125, 37);
            this.button.TabIndex = 20;
            this.button.Text = "Завершить";
            this.button.UseVisualStyleBackColor = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 37);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(145, 19);
            this.progressBar.TabIndex = 0;
            // 
            // teachersTableAdapter1
            // 
            this.teachersTableAdapter1.ClearBeforeFill = true;
            // 
            // resultsTableAdapter1
            // 
            this.resultsTableAdapter1.ClearBeforeFill = true;
            // 
            // PassingTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1156, 623);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PassingTest";
            this.Text = "Прохождение теста";
            this.Load += new System.EventHandler(this.PassingTest_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBoxTextQ;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonNextQ;
        private System.Windows.Forms.Button button;
        private MyTestDataSetTableAdapters.TeachersTableAdapter teachersTableAdapter1;
        private MyTestDataSetTableAdapters.ResultsTableAdapter resultsTableAdapter1;
    }
}