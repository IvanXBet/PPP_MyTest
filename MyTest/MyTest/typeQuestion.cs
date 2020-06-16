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
    public partial class typeQuestion : Form
    {
        private bool temp = false;
        private newTest m_parent;
        public typeQuestion(newTest newTest)
        {
            InitializeComponent();
            m_parent = newTest;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (temp == true)
            {
                newTest newTest = new newTest();
                ClassTotal.temp_interval = 0;
                m_parent.splitContainer3.Panel1.Controls.Clear();
                m_parent.textBoxQuestion.Text = "";
                m_parent.buttonAddAnswer.Visible = true;
                m_parent.buttonSaveQuestion.Visible = true;
                m_parent.buttonСancelQuestion.Visible = true;

                switch (ClassTotal.type)
                {
                    case "Одиночный выбор":
                        for (int i = 0; i < 4; i++)
                        {
                            ClassTotal.RadioButtonDynamic(m_parent.splitContainer3.Panel1, 3, 3 + (i * 40), 17, 20);
                            ClassTotal.TextBoxDynamic(m_parent.splitContainer3.Panel1, 25, 3 + (i * 40), 637, 30);
                        }
                        
                        break;

                    case "Множественный выбор":
                        //m_parent.splitContainer3.Panel1.Controls.Clear();
                        for (int i = 0; i < 4; i++)
                        {
                            ClassTotal.CheckBoxDynamic(m_parent.splitContainer3.Panel1, 3, 3 + (i * 40), 17, 30);
                            ClassTotal.TextBoxDynamic(m_parent.splitContainer3.Panel1, 25, 3 + (i * 40), 637, 30);
                        }
                        
                        break;

                    case "Ввод слова":
                        ClassTotal.TextBoxDynamic(m_parent.splitContainer3.Panel1, 3, 3, 330, 30);
                        
                        break;

                    case "Ввод значения":
                       

                        ClassTotal.TextBoxDynamic(m_parent.splitContainer3.Panel1, 3, 3, 330, 30);
                        m_parent.buttonAddAnswer.Visible = false;

                        break;

                    case "На соответствие":
                        for (int i = 0; i < 4; i++)
                        {
                            ClassTotal.TextBoxDynamic(m_parent.splitContainer3.Panel1, 17, 3 + (i * 40), 300, 30);
                            ClassTotal.TextBoxDynamic(m_parent.splitContainer3.Panel1, 348, 3 + (i * 40), 300, 30);
                        }
                       
                        break;
                }
                this.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ClassTotal.type = "Одиночный выбор";
            m_parent.Type("Одиночный выбор");
            temp = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ClassTotal.type = "Множественный выбор";
            m_parent.Type("Множественный выбор");
            temp = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ClassTotal.type = "Ввод слова";
            m_parent.Type("Ввод слова");
            temp = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ClassTotal.type = "Ввод значения";
            m_parent.Type("Ввод значения");
            temp = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            ClassTotal.type = "На соответствие";
            m_parent.Type("На соответствие");
            temp = true;
        }

        
    }
}
