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
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonWorkWithText_Click(object sender, EventArgs e)
        {
            authorizationTeacher authorizationTeacher = new authorizationTeacher();
            this.Hide();
            authorizationTeacher.Show();
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
