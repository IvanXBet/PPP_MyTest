using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyTest
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }
        public void close() {
            this.close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonWorkWithText_Click(object sender, EventArgs e)
        {
            authorizationTeacher authorizationTeacher = new authorizationTeacher();

            authorizationTeacher.Show();
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            
            ClassTotal.connectionString = Properties.Settings.Default.MyTestConnectionString;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Exit Exit = new Exit();
            Exit.ShowDialog();
        }

        private void buttonPassingTest_Click(object sender, EventArgs e)
        {
            authorizationStudents authorizationStudents = new authorizationStudents();
            authorizationStudents.Show();
        }
    }
}
