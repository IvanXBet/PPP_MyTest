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
        //public string toolStripLabelNameTest
        //{
        //    get { return toolStripLabelNameTest.Text; }
        //    set { toolStripLabelNameTest.Text = value; }
        //}

        public void Test()
        {
            toolStripLabelNameTest.Text = $"Название теста: {ClassTotal.nameTest}";

            toolStripButtonPluses.Visible = true;
            toolStripButtonMinuses.Visible = true;
            toolStripButtonСheck.Visible = true;
            //buttonAddAnswer.Visible = true;
            //buttonSaveQuestion.Visible = true;

        }
        public void Type(string tupe)
        {
            toolStripLabelTypeQuestion.Text = $"Тип вопроса: {tupe}";

            toolStripLabelQuantityQuestions.Text = "Количество вопросов: " + ClassTotal.QuantityQuestions.ToString();

            buttonAddAnswer.Visible = true;
            buttonSaveQuestion.Visible = true;
            buttonСancelQuestion.Visible = true;
        }

        public static int quantitu_question = 0, number_question = 0;
        public newTest()
        {
            InitializeComponent();
        }

        

        private void новыйТестToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NameTest NameTest = new NameTest(this);
            NameTest.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit Exit = new Exit();
            Exit.ShowDialog();
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButtonPluses_Click(object sender, EventArgs e)
        {
            typeQuestion typeQuestion = new typeQuestion(this);
            typeQuestion.ShowDialog();
        }

        private void buttonСancelQuestion_Click(object sender, EventArgs e)
        {
            ClassTotal.type = null;
            toolStripLabelTypeQuestion.Text = "Тип вопроса: Неопределено";
            splitContainer3.Panel1.Controls.Clear();
            textBoxQuestion.Text = "";
        }

        private void newTest_Load(object sender, EventArgs e)
        {
            toolStripLabelQuantityQuestions.Text +=  "0  ";
            toolStripLabelNumberQuestion.Text +=  "0  ";
            toolStripLabelTypeQuestion.Text += "Неопределено";
            toolStripLabelNameTest.Text += "Неопределено";
           
            toolStripButtonPluses.Visible = false;
            toolStripButtonMinuses.Visible = false;
            toolStripButtonСheck.Visible = false;

            buttonAddAnswer.Visible = false;
            buttonSaveQuestion.Visible = false;
            buttonСancelQuestion.Visible = false;
            DateTime dt = DateTime.Today;
            toolStripLabelDate.Text += dt.ToShortDateString();
            
        }
    }
}
