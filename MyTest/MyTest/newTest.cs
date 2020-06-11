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
            int temp_i = 0;
            string ans = "" ; //Ответы вопроса
            bool right = false; //Проверка заполненности обязательных элементов
            switch (ClassTotal.type) //Как сохранять зависит от типа вопроса
            {
                case "Одиночный выбор": //Одиночный: радиокнопка+поле ввода
                                             //Просмотреть все элементы панели
                    for (int i = 0; i < this.splitContainer3.Panel1.Controls.Count; i += 2) //Парами
                    {
                        //Под четными индексами – радиокнопки

                        RadioButton rb = this.splitContainer3.Panel1.Controls[i] as RadioButton;
                        //Под нечетными индексами – поля ввода
                        TextBox tb = this.splitContainer3.Panel1.Controls[i + 1] as TextBox;
                        if (tb.Text != " ") //Сохранять только заполненные вопросы
                        {
                            temp_i++;
                            if (rb.Checked) //Кнопка включена – вопрос выбран
                            {
                                ans += " " +tb.Text +" " ; //Учитывается +
                                if (temp_i > 1)
                                    right = true; //Одна кнопка выбрана
                            }
                            else ans += " -" +tb.Text + " " ; //Выключена – «-«
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

                                if (temp_i > 1)
                                    right = true; //Одна кнопка выбрана
                            }
                            else ans += "-" + tb.Text + ";"; //Выключена – «-«
                        }
                    }
                    break;

                case "Ввод слова":
                    for (int i = 0; i < this.splitContainer3.Panel1.Controls.Count; i++)
                    {
                        TextBox tb = this.splitContainer3.Panel1.Controls[i] as TextBox;
                        if (tb.Text != "") //Сохранять только заполненные вопросы
                        {
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
                            ans += tb.Text;
                            right = true;
                        }
                    }
                    break;

                case "На соответствие":
                    for (int i = 0; i < this.splitContainer3.Panel1.Controls.Count; i += 2)
                    {
                        TextBox tb = this.splitContainer3.Panel1.Controls[i] as TextBox;
                        TextBox tb1 = this.splitContainer3.Panel1.Controls[i + 1] as TextBox;

                        if (tb.Text != "" && tb1.Text != "")
                        {
                            temp_i++;
                            ans += tb.Text + "&" + tb1.Text + ";";
                            right = true;
                        }
                    }
                    break;

            } //Конец swich
            if (!right)
            {
                MessageBox.Show(" Вы не все заполнили в ответах");
                return;
            }
            MessageBox.Show(ans); //Контрольный вывод
                                  //Сохранение вопроса в списке
                                  //Создание нового объекта-вопрос конструктором класса
            ClassQuestion question = new ClassQuestion(textBoxQuestion.Text,  ClassTotal.type, ans);

            listBox.Items.Add(textBoxQuestion.Text); //Добавить его в список вопросов
            listQuestion.Add(question); //В динамический список
            //count_question++; //Учет количества вопросов в тесте
            //this.toolStripStatusКоличество.Text = " Всего вопросов: " + count_question;
            //saveQuestion = true; //Новый вопрос сохранен


            //Подготовка для следующего вопроса
            this.splitContainer3.Panel1.Controls.Clear();
            this.textBoxQuestion.Clear();

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
