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
    public partial class PassingTest : Form
    {
        public List <ClassQuestion> listQuestion = new List <ClassQuestion>();

        public int countAnswers;
        public string[] answerMas;
        public string trueAnswer;
        string typeQuestion;
        string answers;
        int zazorTop = 25,
            comHieght = 20,
            zazor = 30;
        public int trueNumber,
               currentNumber;
        public int totalNumber;
        public int mark;
        private void Show_Question()
        {
            ClassQuestion question = listQuestion[currentNumber - 1]; //Объект-текущий вопрос теста

            this.textBoxTextQ.Text = question.textQuestion; //Получение информации о вопросе
            typeQuestion = question.typeQuestion; //Тип вопроса
            answers = question.answers;
            
            answerMas = answers.Split(';'); //Деление ответов на части
            MessageBox.Show(answerMas[0]);
            countAnswers = answerMas.Length - 1; //Количество ответов
            splitContainer2.Panel2.Controls.Clear(); //Готовим панель для динамических компонентов
            trueAnswer = ""; //Строка правильных ответов
                                         //Отображаем динамические компоненты в зависимости от типа вопроса
            switch (typeQuestion)
            {
                case "Одиночный выбор":
                    for (int i = 0; i < countAnswers; i++)
                    {
                        trueAnswer += answerMas[i][0]; //Первый символ в ответе хранит правильность: + или –
                                                       //Динамические компоненты ответа зависят от типа вопроса
                        ClassTotal.RadioButtonDynamic(splitContainer2.Panel2, 20, zazorTop + i * comHieght + i * zazor, 30, comHieght);
                        ClassTotal.LabelDynamic(splitContainer2.Panel2, 60, zazorTop + i * comHieght + i * zazor, splitContainer2.Panel2.Width - 70, comHieght, answerMas[i].Remove(0, 1));
                    }
                    break;

                case "Множественный выбор":
                    for (int i = 0; i < countAnswers; i++)
                    {
                        trueAnswer += answerMas[i][0];
                        ClassTotal.CheckBoxDynamic(splitContainer2.Panel2, 3, 3 + (i * 40), 17, 20);
                        ClassTotal.LabelDynamic(splitContainer2.Panel2, 25, 3 + (i * 40), 637, 20, answerMas[i].Remove(0, 1));
                    }
                    break;

                case "Ввод значения":
                    trueAnswer = answerMas[0];
                    ClassTotal.TextBoxDynamic(splitContainer2.Panel2, 3, 3, 330, 20);
                    break;

                case "Ввод слова":
                        for (int i = 0; i < countAnswers; i++)
                        {
                            trueAnswer += answerMas[i];
                            ClassTotal.TextBoxDynamic(splitContainer2.Panel2, 3, 3 + (i * 40), 330, 20);
                        }
                    break;

                case "На соответствие":
                    string[] first = new string[countAnswers];
                    string[] second = new string[countAnswers];
                    for (int i = 0; i < countAnswers; i++)
                    {
                        string[] an = answerMas[i].Split('&');
                        first[i] = an[0];
                        second[i] = an[1];
                    }
                    for (int i = 0; i < countAnswers; i++)
                    {
                        trueAnswer += second[i];
                        ClassTotal.LabelDynamic(splitContainer2.Panel2, 17, 3 + (i * 40), 300, 20, first[i]);
                        ClassTotal.ComboBoxDynamic(splitContainer2.Panel2, 348, 3 + (i * 40), 300, 20, second);
                    }
                    break;
                    
            }
        }
        public PassingTest()
        {
            InitializeComponent();
        }

        private void buttonNextQ_Click(object sender, EventArgs e)
        {
            //Обработка ответов на текущий вопрос теста
            string s = ""; //Строка из + и – по ответам
            bool right = false; //Флаг правильности ответа
                                //Анализ ответа на текущий вопрос в зависимости от типа вопроса
            switch (typeQuestion) //Тип вопроса
            {
                case "Одиночный выбор":
                    for (int i = 0; i < splitContainer2.Panel2.Controls.Count; i++) //Количество компонент в панели
{
                        if (splitContainer2.Panel2.Controls[i] is RadioButton) //Если компонент – кнопка
                        {
                            RadioButton rb = splitContainer2.Panel2.Controls[i] as RadioButton; //Получить кнопку
                            if (rb.Checked) s += '+'; //Создание строки с ответами
                            else s += '-';
                         }
                    }
                    if (s == trueAnswer) right = true; //Сравнить полученные ответы с заданными
                    break;

                case "Множественный выбор":
                    for (int i = 0; i < splitContainer2.Panel2.Controls.Count; i++) {

                        if (splitContainer2.Panel2.Controls[i] is CheckBox) //Если компонент – кнопка
                        {
                            CheckBox chb = splitContainer2.Panel2.Controls[i] as CheckBox; //Получить кнопку
                            if (chb.Checked) s += '+'; //Создание строки с ответами
                            else s += '-';
                        }
                    }
                    if (s == trueAnswer) right = true;
                        break;
                    case "Ввод слова":
                    for (int i = 0; i < splitContainer2.Panel2.Controls.Count; i++)
                    {
                        if (splitContainer2.Panel2.Controls[i] is TextBox) //Если компонент – кнопка
                        {
                            TextBox tb = splitContainer2.Panel2.Controls[i] as TextBox; //Получить кнопку
                            s = tb.Text;
                        }
                    }
                    break;
                    case "Ввод значения":
                    for (int i = 0; i < splitContainer2.Panel2.Controls.Count; i++)
                    {
                        if (splitContainer2.Panel2.Controls[i] is TextBox) //Если компонент – кнопка
                        {
                            TextBox tb = splitContainer2.Panel2.Controls[i] as TextBox; //Получить кнопку
                            s = tb.Text;
                        }
                    }
                       break;

                case "На соответствие":
                    for (int i = 0; i < splitContainer2.Panel1.Controls.Count; i++)
                    {
                        if (splitContainer2.Panel1.Controls[i] is ComboBox)
                        {
                            ComboBox tb2 = this.splitContainer2.Panel1.Controls[i] as ComboBox;
                            s += tb2.Text;
                        }

                    }
                    if (s == trueAnswer)
                        right = true;
                    break;
            }
            //Анализ результата ответа на текущий вопрос
            if (right)
            {
                MessageBox.Show(" Вопрос отвечен верно ");
                trueNumber++;
            }
            else
            {
                MessageBox.Show(" Вопрос отвечен не верно");
                MessageBox.Show(trueAnswer, s);

            }
                            //Проверка завершения теста
            if (currentNumber < totalNumber) //Еще не все вопросы пройдены
            {
                currentNumber++; //Номер следующего вопроса
                Show_Question(); //Отобразить компоненты от типа вопроса
            }else                 //Пройдены все вопросы теста
                {
                    //Расчет оценки в зависимости от числа правильно отвеченных вопросов
                double proc = trueNumber * 100.0 / totalNumber;
                if (proc > 80) mark = 5;
                else
                if (proc > 65) mark = 4;
                else
                if (proc > 50) mark = 3;
                else mark = 2;
                //Занесение данных о результатах прохождения теста в таблицу Results БД
                this.resultsTableAdapter1.Insert(ClassTotal.idStud, ClassTotal.idTest, DateTime.Now, mark);
                this.Close();
                }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PassingTest_Load(object sender, EventArgs e)
        {
            
            listQuestion.Clear();
            string query;
            
            string textQuestion,
                    typeQuestion,
                   answers;
            mark = 0;


            SqlConnection connection = new SqlConnection(ClassTotal.connectionString);
            connection.Open();
            try
            {
                //Выборка всех данных из динамической таблицы с вопросами теста
                query = "SELECT * FROM " + ClassTotal.nameTest  + "_" + ClassTotal.idTeacher;
                
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader dataReader = command.ExecuteReader(); //Все записи
                                                                    //Перенести все вопросы теста в список
                while (dataReader.Read()) //Перебрать все записи по одной
                {
                    //Получение полей текущей записи
                    textQuestion = dataReader["Text_question"].ToString();
                    typeQuestion = dataReader["Type_question"].ToString();
                    answers = dataReader["Answers"].ToString();
                    //Создание объекта-вопроса конструктором
                    ClassQuestion question = new ClassQuestion(textQuestion, typeQuestion, answers);
                    listQuestion.Add(question); //Добавление вопроса в список
                }
                dataReader.Close();
                connection.Close();

                totalNumber = listQuestion.Count; //Общее количество вопросов
                this.progressBar.Maximum = totalNumber;
                currentNumber = 1; //Текущий номер вопроса
                trueNumber = 0; //Количество правильных ответов
                Show_Question();
            }
            catch
            {
                MessageBox.Show("Данный тест был удален.\r\nОбратитесь к преподавателю.");
                
                connection.Close();
                this.Close();
                return;
            }
        }
    }
}
