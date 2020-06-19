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
        
        public bool save = true;
        public List<ClassQuestion> listQuestion = new List<ClassQuestion>();
        //SqlConnection Conn = new SqlConnection("Data Source=DESKTOP-ALK89E7\\SQLEXPRESS;Initial Catalog=MyTest;Integrated Security=True");
        public static int quantitu_question = 0, number_question = 0;

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

        

        private void buttonSaveQuestion_Click(object sender, EventArgs e)
        { 
            ClassTotal.ans = "";
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
                                    ClassTotal.ans += "+"+tb.Text + ";"; //Учитывается +

                                    
                                     right = true; //Одна кнопка выбрана
                                }
                                else ClassTotal.ans += "-"+tb.Text + ";"; //Выключена – «-«

                            }
                            else
                            {
                                MessageBox.Show("Заполнины не все поля");
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
                                    ClassTotal.ans += "+" + tb.Text + ";"; //Учитывается +


                                    right = true; //Одна кнопка выбрана
                                }
                                else ClassTotal.ans += "-" + tb.Text + ";"; //Выключена – «-«
                            }
                            else {
                                MessageBox.Show("Заполнины не все поля");
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
                                ClassTotal.ans += tb.Text + ";"; 
                                right = true; 
                            }
                            else
                            {
                                MessageBox.Show("Заполнины не все поля");
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
                                ClassTotal.ans += tb.Text;
                                right = true;
                            }
                            else
                            {
                                MessageBox.Show("Заполнины не все поля");
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
                                ClassTotal.ans += tb.Text + "&" + tb1.Text +";";
                                right = true;
                            }
                            else
                            {
                                MessageBox.Show("Заполнины не все поля");
                            }
                        }
                        break;

                }

                if(right == true && temp_i > 1)
                {
                    
                    ClassQuestion question = new ClassQuestion(textBoxQuestion.Text, ClassTotal.type, ClassTotal.ans);
                    listQuestion.Add(question);
                    ClassTotal.QuantityQuestions++;
                    //toolStripLabelNumberQuestion.Text = "Номер вопроса: " + ClassTotal.NumberQuestion;
                    toolStripLabelQuantityQuestions.Text = "Количество вопросов: " + ClassTotal.QuantityQuestions;
                    MessageBox.Show(ClassTotal.ans);
                    listBox.Items.Add(textBoxQuestion.Text);
                    this.splitContainer3.Panel1.Controls.Clear();
                    this.textBoxQuestion.Text = "";
                    ClassTotal.type = null;
                    
                }
                else
                {
                    MessageBox.Show("Заполнины не все поля");
                }

            }
            else{
                MessageBox.Show("Заполните вопрос");
            }
        }

        private void сохранитьТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save = true;
            if (listBox.Items.Count < 1)
            {
                save = false;
                MessageBox.Show("Тест пустой");
            }

            MessageBox.Show(ClassTotal.nameTest + "_" + ClassTotal.idTeacher);
            string query = "SELECT name FROM  sys.tables";
            SqlConnection connection = new SqlConnection(ClassTotal.connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader[0].ToString() == ClassTotal.nameTest + "_" + ClassTotal.idTeacher)
                {
                    save = false;
                    MessageBox.Show("Тест с таким названием уже создан.\nПереименуйте тест");
                    NameTest ntf = new NameTest(this);
                    ntf.Show();
                }
            }
            reader.Close();
            connection.Close();

            


            if (save == true)
            {
                query = "CREATE TABLE [" + ClassTotal.nameTest + "_" + ClassTotal.idTeacher +
                   "] ([ID_question] INT IDENTITY(1,1) NOT NULL PRIMARY KEY," +
                   "[Text_question] nvarchar(100) NOT NULL," +
                   "[Type_question] nvarchar(100) NOT NULL, " +
                   "[Answers] nvarchar(100) NOT NULL)";
                connection.Open();
                command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                foreach (ClassQuestion item in listQuestion)
                {
                    string query1 = "INSERT INTO [" + ClassTotal.nameTest + "_" + ClassTotal.idTeacher +
                   "] ([Text_question], [Type_question], [Answers]) " +
                    "VALUES ('" + item.textQuestion + "', '" + item.typeQuestion + "', '" + item.answers + "')";
                    SqlCommand command1 = new SqlCommand(query1, connection);
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Тест успешно сохранён");
                }
                DateTime dt = DateTime.Today;

                query = "INSERT INTO [Tests] ([ID_teacher], [Name_test], [Date_create]) VALUES ('" + ClassTotal.idTeacher + "','" + ClassTotal.nameTest + "','" +
                    dt.ToShortDateString() + "')";
                command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Тест успешно записан в бд");
                connection.Close();

            }
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
            toolStripLabelNumberQuestion.Text = "Номер вопроса: " + (listBox.SelectedIndex + 1);
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsTest StatisticsTest = new StatisticsTest();
            StatisticsTest.Show();
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
