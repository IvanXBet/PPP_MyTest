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
    public partial class NameTest : Form
    {
        public NameTest()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxNameTest.Text == " " || textBoxNameTest.Text == "")
            {
                MessageBox.Show("Введите название");
            }
            else {
                
                ClassTotal.nameTest = textBoxNameTest.Text;
                newTest newTest = new newTest();
                this.Close();
                newTest.ShowDialog();
            }
        }
    }
}
