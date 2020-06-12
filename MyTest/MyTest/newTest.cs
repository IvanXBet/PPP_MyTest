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
    
    public partial class newTest : Form
    {
        //public string toolStripLabelNameTest
        //{
        //    get { return toolStripLabelNameTest.Text; }
        //    set { toolStripLabelNameTest.Text = value; }
        //}
        public static string ans = "";

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

        List<ClassQuestion> listQuestion = new List<ClassQuestion>();

        private void buttonSaveQuestion_Click(object sender, EventArgs e)
        { 
            ans = "";
            int temp_i = 0;
             //Ответы вопроса
            bool right = false;
            if(textBoxQuestion.Text != "")
            { 
                
                switch (ClassTotal.type)
                {
                    case "Одиночный выбор":
                        for (int i = 0; i < this.splitContainer3.Panel1.Controls.Count; i += 2) 
                        {
                            RadioButton rb = this.splitContainer3.Panel1.Controls[i] as RadioButton;
                            TextBox tb = this.splitContainer3.Panel1.Controls[i + 1] as TextBox;
                            if (tb.Text != "") //Сохранять только заполненные вопросы
                            {
                                temp_i++;

                                if (rb.Checked) //Кнопка включена – вопрос выбран
                                {
                                    ans += "+"+tb.Text + ";"; //Учитывается +

                                    
                                     right = true; //Одна кнопка выбрана
                                }
                                else ans += "-"+tb.Text + ";"; //Выключена – «-«
                            }
                        }
                            break;

                    case "Множественный выбор":
                        for (int i = 0; i < this.splitContainer3.Panel1.Controls.Count; i += 2)
                        {
                            CheckBox rb = this.splitContainer3.Panel1.Controls[i] as CheckBox;
                            TextBox tb = this.splitContainer3.Panel1.Controls[i + 1] as TextBox;
                            if (tb.Text != "") //Сохранять только заполненные вопросы
                            {
                                temp_i++;

                                if (rb.Checked) //Кнопка включена – вопрос выбран
                                {
                                    ans += "+" + tb.Text + ";"; //Учитывается +

                                  
                                        right = true; //Одна кнопка выбрана
                                }
                                else ans += "-" + tb.Text + ";"; //Выключена – «-«
                            }
                        }

                        break;

                    case "Ввод слова":
                        for (int i = 0; i < this.splitContainer3.Panel1.Controls.Count; i ++)
                        {
                            TextBox tb = this.splitContainer3.Panel1.Controls[i] as TextBox;
                            if (tb.Text != "") //Сохранять только заполненные вопросы
                            {
                                temp_i = 2;
                                ans += tb.Text + ";"; 
                                right = true; 
                            }
                        }
                        break;

                    case "Ввод значения":
                        for (int i = 0; i < this.splitContainer3.Panel1.Controls.Count; i++)
                        {
                            TextBox tb = this.splitContainer3.Panel1.Controls[i] as TextBox;
                            if (tb.Text != "") //Сохранять только заполненные вопросы
                            {
                                temp_i = 2;
                                ans += tb.Text;
                                right = true;
                            }
                        }
                        break;

                    case "На соответствие":
                        for (int i = 0; i < this.splitContainer3.Panel1.Controls.Count; i+=2)
                        {
                            TextBox tb = this.splitContainer3.Panel1.Controls[i] as TextBox;
                            TextBox tb1 = this.splitContainer3.Panel1.Controls[i+1] as TextBox;
                            
                            if (tb.Text != "" && tb1.Text != "") 
                            {
                                temp_i++;
                                ans += tb.Text + "&" + tb1.Text +";";
                                right = true;
                            }
                        }
                        break;

                }

                if(right == true && temp_i >1)
                {
                    
                    ClassQuestion question = new ClassQuestion(textBoxQuestion.Text, ClassTotal.type, ans);
                    listQuestion.Add(question);
                    ClassTotal.QuantityQuestions++;
                    toolStripLabelNumberQuestion.Text = "Номер вопроса: " + ClassTotal.QuantityQuestions;
                    toolStripLabelQuantityQuestions.Text = "Количество вопросов: " + ClassTotal.QuantityQuestions;
                    MessageBox.Show(ans);
                    listBox.Items.Add(textBoxQuestion.Text);
                    this.splitContainer3.Panel1.Controls.Clear();
                    this.textBoxQuestion.Text = "";
                    ClassTotal.type = null;
                    
                }
                
            }
        }

        private void сохранитьТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-ALK89E7\\SQLEXPRESS;Initial Catalog=MyTest;Integrated Security=True");
            string query = "CREATE TABLE " + ClassTotal.nameTest +
                " ([ID_question] INT IDENTITY(1,1) NOT NULL PRIMARY KEY," +
                "[Text_question] nvarchar(100) NOT NULL," +
                "[Type_question] nvarchar(100) NOT NULL, " +
                "[Answers] nvarchar(100) NOT NULL)";
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            foreach (ClassQuestion item in listQuestion)
            {
                string query1 = "INSERT INTO " + ClassTotal.nameTest +
            " ([Text_question], [Type_question], [Answers]) " +
            "VALUES ('" + item.textQuestion + "', '" + item.typeQuestion + "', '" + item.answers + "')";

                SqlCommand command1 = new SqlCommand(query1, con);
                command1.ExecuteNonQuery();

            }
            con.Close();
        }

        private void buttonAddAnswer_Click(object sender, EventArgs e)
        {
            ClassTotal.temp_interval++;
            switch (ClassTotal.type)
            {
                case "Одиночный выбор":
                    ClassTotal.RadioButtonDynamic(splitContainer3.Panel1, 3, 120 + (ClassTotal.temp_interval * 40), 17, 20);
                    ClassTotal.TextBoxDynamic(splitContainer3.Panel1, 25, 120 + (ClassTotal.temp_interval * 40), 637, 20);
                    break;

                case "Множественный выбор":
                    ClassTotal.CheckBoxDynamic(splitContainer3.Panel1, 3, 120 + (ClassTotal.temp_interval * 40), 17, 20);
                    ClassTotal.TextBoxDynamic(splitContainer3.Panel1, 25, 120 + (ClassTotal.temp_interval * 40), 637, 20);
                    break;

                case "Ввод слова":
                    ClassTotal.TextBoxDynamic(splitContainer3.Panel1, 3, 3 + (ClassTotal.temp_interval * 40), 330, 20);
                    break;

                case "На соответствие":
                    ClassTotal.TextBoxDynamic(splitContainer3.Panel1, 17, 120 + (ClassTotal.temp_interval * 40), 300, 20);
                    ClassTotal.TextBoxDynamic(splitContainer3.Panel1, 348, 120 + (ClassTotal.temp_interval * 40), 300, 20);
                    break;
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripLabelNumberQuestion.Text = "Номер вопроса: " + listBox.SelectedIndex + 1;
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
