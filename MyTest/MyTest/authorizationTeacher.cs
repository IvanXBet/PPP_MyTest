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
    public partial class authorizationTeacher : Form
    {
        
        public authorizationTeacher()
        {
            InitializeComponent();
            
        }

        private void buttonSingin_Click(object sender, EventArgs e)
        {
            string log, pass;
            //
            textBoxLogin.Text = "LogT1";
            textBoxPassword.Text = "123";
            //
            log = textBoxLogin.Text;
            pass = textBoxPassword.Text;
            

            var rec = this.teachersTableAdapter1.GetData();
            var filter = rec.Where(p => p.Login == log && p.Password == pass);
            if (filter.Count() == 0)
                MessageBox.Show("Таких данных нет.");
            else {
                ClassTotal.idTeacher = filter.ElementAt(0).ID_teacher;
                ClassTotal.nameTeacher = filter.ElementAt(0).Name_teacher;
                //MessageBox.Show("Вы успешно авторизовались как преподаватель.");
                newTest newTest = new newTest();
               
                this.Hide();
                
                newTest.ShowDialog();
                
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            registrationTeacher registrationTeacher = new registrationTeacher();
            this.Hide();
            registrationTeacher.ShowDialog();
        }
    }
}
