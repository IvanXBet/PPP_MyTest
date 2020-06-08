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
    public partial class newTest : Form
    {

        public static int quantitu_question = 0, number_question = 0;
        public newTest()
        {
            InitializeComponent();
        }

        

        private void новыйТестToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NameTest NameTest = new NameTest();
            this.Close();
            NameTest.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit Exit = new Exit();
            Exit.ShowDialog();
            
        }

        private void newTest_Load(object sender, EventArgs e)
        {
            toolStripLabelQuantityQuestions.Text += quantitu_question + "  ";
            toolStripLabelNumberQuestion.Text += number_question + "  ";
            toolStripLabelTypeQuestion.Text += "Неопределено";
            toolStrip1.Visible = false;
            toolStrip.Visible = false;
            buttonAddAnswer.Visible = false;
            buttonSaveQuestion.Visible = false;
            if (ClassTotal.nameTest != null)
            {
                toolStripLabelNameTest.Text += ClassTotal.nameTest + "  ";
                toolStrip1.Visible = true;
                toolStrip.Visible = true;
                buttonAddAnswer.Visible = true;
                buttonSaveQuestion.Visible = true;
                DateTime dt = DateTime.Today;
                toolStripLabelDate.Text += dt.ToShortDateString();
            }
        }
    }
}
