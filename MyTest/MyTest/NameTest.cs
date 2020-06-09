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
        private newTest m_parent;

        

        public NameTest(newTest newTest)
        {
            InitializeComponent();
            m_parent = newTest;
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

                this.Close();
                //newTest.Owner = this;
                //newTest.toolStripLabelNameTest.Text =$"Название теста {textBoxNameTest.Text}";

                //newTest.ShowDialog();
            }
        }

        private void NameTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_parent.Test();
        }
    }
}
