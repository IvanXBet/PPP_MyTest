using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyTest
{
    class ClassTotal
    {
        public static int idTeacher;
        public static string nameTeacher;
        public static string nameTest;
        public static string TypeQuestion;
        public static int QuantityQuestions = 0;
        public static int NumberQuestion = 1;
        public static int temp_interval = 0;
        public static string type;
        public static string ans = "";
        public static string connectionString;
        //
        public static int idStud; //ID студента при регистрации
        public static int idTest; //ID выбранного теста


        //Метод создания динамического поля ввода
        //Параметры: Владелец, положение, размер компонента в контейнере
        public static void TextBoxDynamic(Panel panel, int left, int top, int width, int height)
        {
            TextBox tb = new TextBox(); //Выделение памяти под компонент
            tb.Multiline = true; //Настройка необходимых свойств
            
            tb.Height = height;
            tb.Width = width;
            tb.Left = left;
            tb.Top = top;
            
            tb.Text = " ";
            tb.ReadOnly = false;
            panel.Controls.Add(tb); //Указание владельца этого компонента
        }
        //Метод создания динамической радиокнопки
        //Параметры: Владелец, положение, размер компонента в контейнере
        public static void RadioButtonDynamic(Panel panel, int left, int top, int width, int height)
        {
            RadioButton rb = new RadioButton();
            rb.Height = height;

            rb.Width = width;
            rb.Left = left;
            rb.Top = top;
            rb.Text = "";
            panel.Controls.Add(rb);
        }
        //Метод создания динамического флажка
        //Параметры: Владелец, положение, размер
        public static void CheckBoxDynamic(Panel panel, int left, int top, int width, int height)
        {
            CheckBox cb = new CheckBox();
            cb.Height = height;

            cb.Width = width;
            cb.Left = left;
            cb.Top = top;
            cb.Text = "";
            panel.Controls.Add(cb);
        }


    }
}

