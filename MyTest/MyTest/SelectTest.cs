using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTest
{
    public partial class SelectTest : Form
    {
        public SelectTest()
        {
            InitializeComponent();
        }

        private void SelectTest_Load(object sender, EventArgs e)
        {
            this.dataGridView.DataSource = this.testTeachersTableAdapter1.GetData();
            this.dataGridView.Columns["ID_test"].Visible = false;
            this.dataGridView.Columns["ID_teacher"].Visible = false;
            this.dataGridView.Columns["Name_test"].HeaderText = " Название теста";
            this.dataGridView.Columns["Name_teacher"].HeaderText = " Преподаватель ";
            this.dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonSelectTest_Click(object sender, EventArgs e)
        {
            ClassTotal.idTest = (int)this.dataGridView.CurrentRow.Cells["ID_test"].Value;
            ClassTotal.nameTest = (string)this.dataGridView.CurrentRow.Cells["Name_test"].Value;
            ClassTotal.idTeacher = (int)this.dataGridView.CurrentRow.Cells["ID_teacher"].Value;
            PassingTest PassingTest = new PassingTest();
            this.Close();
            PassingTest.Show();
        }
    }
}
