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
    public partial class authorizationStudents : Form
    {
        public authorizationStudents()
        {
            InitializeComponent();
        }

        private void labelNameFormStud_Click(object sender, EventArgs e)
        {

        }

        private void buttonSingin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void authorizationStudents_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myTestDataSet.Teams". При необходимости она может быть перемещена или удалена.
            this.teamsTableAdapter.Fill(this.myTestDataSet.Teams);
            this.comboBoxGroupStud.DataSource = this.myTestDataSet.Teams;
            this.comboBoxGroupStud.DisplayMember = "team";
            this.comboBoxGroupStud.ValueMember = "id_team";
        }

        private void comboBoxGroupStud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            string nameStud;
            int idTeam;
            nameStud = this.textBoxLoginStud.Text;
            idTeam = (int)this.comboBoxGroupStud.SelectedValue;

            var rec = this.studentsTableAdapter1.GetData().
            Where(p => p.Nmae_student == nameStud && p.ID_team == idTeam);

            if (rec.Count() == 0) //Новый студент
            {
                try
                {
                    this.studentsTableAdapter1.Insert(nameStud, idTeam); //Добавление нового
                    var x = this.studentsTableAdapter1.GetData(); //Получить обновленные записи
                    
                    ClassTotal.idStud = x.Last().ID_student; //Сохранить ID последнего студента
                    MessageBox.Show(" Вас успешно зарегистрировали в системе.\r\nМожете проходить тест.");
                    SelectTest SelectTest = new SelectTest();
                    this.Hide();
                    SelectTest.Show();
                }
                catch
                {
                    MessageBox.Show(" Вас не удалось зарегистрировать в системе.");
                    this.Close(); return;
                }
            }
            else //Вы уже были в системе
            {
                ClassTotal.idStud = rec.ElementAt(0).ID_student; //Получить ID студента
                MessageBox.Show(" Вас успешно авторизировались в системе.\r\nМожете проходить тест.");
                SelectTest SelectTest = new SelectTest();
                this.Hide();
                SelectTest.Show();
            }
        }
    }
    
}
