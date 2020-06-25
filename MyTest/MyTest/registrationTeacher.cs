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
    public partial class registrationTeacher : Form
    {
        public registrationTeacher()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelNameRegistrationTeacher_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            authorizationTeacher authorizationTeacher = new authorizationTeacher();
            this.Hide();
            authorizationTeacher.Show();
        }

        private void buttonSingin_Click(object sender, EventArgs e)
        {
            string log, pass, pass2, name;
            log = textBoxNewLogin.Text;
            pass = textBoxNewPassword.Text;
            pass2 = textBoxRepeatPassword.Text;
            name = textBoxNewName.Text;

            

            var rec = this.teachersTableAdapter1.GetData();
            var filter = rec.Where(p => p.Login == log && p.Password == pass);
            if (filter.Count() > 0)
                MessageBox.Show("Такой преподаватель есть в БД");
            else {
                try
                {
                    if (log == "" || pass == "" || name == "" || pass2 == "")
                    {
                        MessageBox.Show("Введины не все днные");
                    }

                    else if (pass == pass2)
                    {
                        this.teachersTableAdapter1.Insert(log, pass, name);
                        var temp = this.teachersTableAdapter1.GetData(); //Все записи после добавления
                        int maxID = temp.Last().ID_teacher; //ID добавленной записи
                        ClassTotal.idTeacher = maxID;
                        ClassTotal.nameTeacher = name;
                        MessageBox.Show("Ваши учетные данные занесены в БД успешно");


                        newTest newTest = new newTest();
                        this.Hide();
                        newTest.ShowDialog();
                        MessageBox.Show("Переход в форму работы с текстом");
                    }
                    else {
                        MessageBox.Show("Пароли не совпадают");
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Ошибка при внесении Ваших учетных данных.");
                }
            }
        }
    }
}
