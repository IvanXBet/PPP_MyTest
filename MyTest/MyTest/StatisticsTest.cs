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
    public partial class StatisticsTest : Form
    {
        public MyTestDataSet.StatisticsDataTable records;
        public StatisticsTest()
        {
            InitializeComponent();
        }

        private void StatisticsTest_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myTestDataSet1.Tests". При необходимости она может быть перемещена или удалена.
            this.testsTableAdapter.Fill(this.myTestDataSet1.Tests);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myTestDataSet1.Teams". При необходимости она может быть перемещена или удалена.
            this.teamsTableAdapter.Fill(this.myTestDataSet1.Teams);
            records = statisticsTableAdapter1.GetDataIDTeacher(ClassTotal.idTeacher);
            this.textBoxNameStudent.Visible = false;
            this.comboBoxGroup.Visible = false;
            this.comboBoxNameTest.Visible = false;
            this.dateTimePickerStart.Visible = false;
            this.dateTimePickerFinish.Visible = false;
            this.numericUpDownMark.Visible = false;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Показать все результаты":
                    this.textBoxNameStudent.Visible = false;
                    this.comboBoxGroup.Visible = false;
                    this.comboBoxNameTest.Visible = false;
                    this.dateTimePickerStart.Visible = false;
                    this.dateTimePickerFinish.Visible = false;
                    this.numericUpDownMark.Visible = false;
                    break;

                case "Поиск студентов по ФИО":
                    this.textBoxNameStudent.Visible = true;
                    this.comboBoxGroup.Visible = false;
                    this.comboBoxNameTest.Visible = false;
                    this.dateTimePickerStart.Visible = false;
                    this.dateTimePickerFinish.Visible = false;
                    this.numericUpDownMark.Visible = false;
                    break;

                case "Отобрать по группе":
                    this.comboBoxGroup.Visible = true;
                    this.textBoxNameStudent.Visible = false;
                    this.comboBoxNameTest.Visible = false;
                    this.dateTimePickerStart.Visible = false;
                    this.dateTimePickerFinish.Visible = false;
                    this.numericUpDownMark.Visible = false;
                    break;

                case "Отобрать по названию теста":
                    this.comboBoxNameTest.Visible = true;
                    this.textBoxNameStudent.Visible = false;
                    this.comboBoxGroup.Visible = false;
                    this.dateTimePickerStart.Visible = false;
                    this.dateTimePickerFinish.Visible = false;
                    this.numericUpDownMark.Visible = false;
                    break;

                case "Фильтрация по интервалу дат":
                    this.dateTimePickerStart.Visible = true;
                    this.dateTimePickerFinish.Visible = true;
                    this.comboBoxNameTest.Visible = false;
                    this.textBoxNameStudent.Visible = false;
                    this.comboBoxGroup.Visible = false;
                    this.numericUpDownMark.Visible = false;
                    break;

                case "Отбор по оценке":
                    this.numericUpDownMark.Visible = true;
                    this.dateTimePickerStart.Visible = false;
                    this.dateTimePickerFinish.Visible = false;
                    this.comboBoxNameTest.Visible = false;
                    this.textBoxNameStudent.Visible = false;
                    this.comboBoxGroup.Visible = false;
                    break;
            }

        }

        private void buttonAddAnswer_Click(object sender, EventArgs e)
        {
            switch (comboBox.Text)
            {
                case "Показать все результаты":
                    var recAll = this.statisticsTableAdapter1.GetDataIDTeacher(ClassTotal.idTeacher);
                    this.dataGridView.DataSource = recAll;
                    this.labelResults.Text = $"Результатов {recAll.Count()}";
                    break;

                case "Поиск студентов по ФИО":
                    
                    var recFIO = this.statisticsTableAdapter1.GetDataByFIO(ClassTotal.idTeacher, textBoxNameStudent.Text);
                    this.dataGridView.DataSource = recFIO;
                    this.labelResults.Text = $"Результатов {recFIO.Count()}";
                    break;

                case "Отобрать по группе":
                    var recGroup = this.statisticsTableAdapter1.GetDataByNameGroup(ClassTotal.idTeacher,comboBoxGroup.Text);
                    this.dataGridView.DataSource = recGroup;
                    this.labelResults.Text = $"Результатов {recGroup.Count()}";
                    break;

                case "Отобрать по названию теста":
                    var recNameTest = this.statisticsTableAdapter1.GetDataByNameTest(ClassTotal.idTeacher, comboBoxNameTest.Text);
                    this.dataGridView.DataSource = recNameTest;
                    this.labelResults.Text = $"Результатов {recNameTest.Count()}";
                    break;

                case "Фильтрация по интервалу дат":
                    string Start = Convert.ToString(dateTimePickerStart.Value.Date),
                        Finifsh = Convert.ToString(dateTimePickerFinish.Value.Date);
                    var recStartFirsr = this.statisticsTableAdapter1.GetDataByStartFinish(ClassTotal.idTeacher, Start, Finifsh);
                    this.dataGridView.DataSource = recStartFirsr;
                    this.labelResults.Text = $"Результатов {recStartFirsr.Count()}";
                    break;

                case "Отбор по оценке":
                    int mark = Convert.ToInt32(numericUpDownMark.Value);
                    var recMark = this.statisticsTableAdapter1.GetDataByMark(ClassTotal.idTeacher, mark);
                    this.dataGridView.DataSource = recMark;
                    this.labelResults.Text = $"Результатов {recMark.Count()}";
                    break;
            }
        }
    }
}
