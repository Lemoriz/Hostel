using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Отель
{
    public partial class Otel : Form
    {
        JArray results = null; //Экземпляр класса Jarray равный null
        public int rowIndex; 

        public Otel()
        {
            InitializeComponent();
            WorkWithFile.LoadArray("Employee.txt"); //Открывается файл при инициализации формы
            this.lastName.HidePromptOnLeave = true;
            this.firstName.HidePromptOnLeave = true;
            this.midlleName.HidePromptOnLeave = true;
            this.position.HidePromptOnLeave = true;
            this.citizenShip.HidePromptOnLeave = true;
            this.homeAddress.HidePromptOnLeave = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void CardAdm_Click(object sender, EventArgs e) //Открытие нужной карточки
        {
            var q = dataGridViewSearchAdm.CurrentCell.RowIndex; //Получаем индекс того, где находится курсор

            if(results == null) //Проверка на отсутствие рез-та
            {
                return;
            }
            if(q > results.Count-1)//Если курсор за границами
            {
                return;
            }

            var bio = results[q]; //Получаем выделенную запись
            
            int x = 0;
            for(x=0;x<WorkWithFile.jArray.Count-1;x++) //Находим нужную запись в списке
            {
                if (JToken.DeepEquals(WorkWithFile.jArray[x], bio))//Сравнивем два объекта
                    break;
            }

            var ds = new Карта_сотрудника(x, accessLevels.admin);

            ds.Show(); //Открытие карточки сотрудника по индексу нужной записи
        }

        private void addEmployeer_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dateIssue.Text) <= DateTime.Now)//Проверка на ввод даты, которая больше сегодняшней
            {
                Bio bio = new Bio //Создаем новый экземпляр Bio и иницилизируем его значениями, которые ввел пользователь
                {
                    Имя = firstName.Text,
                    Фамилия = lastName.Text,
                    Отчество = midlleName.Text,
                    Должность = position.Text,
                    Серия_паспорта = series.Text,
                    Дата_выдачи = dateIssue.Text,
                    Номер_паспорта = number.Text,
                    Пол = sex.Text,
                    Страховой_номер = insurance.Text,
                    Семейное_положение = famileStatus.Text,
                    Фактический_адрес_проживания = homeAddress.Text,
                    Серия_рудовой_книжки = seriesWorkBook.Text,
                    Номер_трудовой_книжки = nuberWorkBook.Text,
                    Вкладыш = insertionWorkBook.Text,
                    Гражданство = citizenShip.Text
                };
                WorkWithFile.jArray.Add(JToken.FromObject(bio));//Добавляем в основной массив
                WorkWithFile.SaveArray("Employee.txt");//Сохраняем измененный массив в файл
                MessageBox.Show("Запись добавлена", "Успешно");
            }
            else MessageBox.Show("Дата не может быть больше сегодняшней", "Ошибка!");
        }

        private void SearchAdm_Click(object sender, EventArgs e)
        {
            if (SearchPatronymic.Text == "" && SearchPosition.Text == ""
                && НайтиФамилию.Text == ""
                && SearchFirstName.Text == "") //Проверки на пустые поля в параметрах поиска
                return;

            var q =  WorkWithFile.jArray.Where(   //Лямбда-функция для поиска нужного сотрудника по критериям поиска
                a => {
                    var f = a.ToObject<Bio>();
                   
                    if(SearchFirstName.Text != "")
                    {
                        if (SearchFirstName.Text != f.Имя)
                            return false;
                    }
                    if (НайтиФамилию.Text != "")
                    {
                        if (НайтиФамилию.Text != f.Фамилия)
                            return false;
                    }
                    if (SearchPatronymic.Text != "")
                    {
                        if (SearchPatronymic.Text != f.Отчество)
                            return false;
                    }
                    if (SearchPosition.Text != "")
                    {
                        if (SearchPosition.Text != f.Должность)
                            return false;
                    }
                    return true;
                }
                );

            results = JArray.FromObject(q); //Запись рез-та поиска в новый экземпляр класса Json
           
            dataGridViewSearchAdm.DataSource = results;  //Вывод результатов поиска в датагрид
        }

        private void tabControlAdm_Click(object sender, EventArgs e)
        {
            dataGridViewListUser.DataSource = WorkWithFile.jArray;
        }

        private void Otel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();//Закрытие всего приложения при нажатии на крестик
        }

        private void dataGridViewSearchAdm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewListUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Otel_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewSearchAdm_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridViewListUser_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            WorkWithFile.SaveArray("Employee.txt");
        }

        private void dataGridViewListUser_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >0) //Обработка правого клика на удаление записи
            {
                
                    this.dataGridViewListUser.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    this.dataGridViewListUser.CurrentCell = this.dataGridViewListUser.Rows[e.RowIndex].Cells[1];
                    this.contextMenuStrip1.Show(this.dataGridViewListUser, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e) //Обработка 
        {
            this.dataGridViewListUser.Rows.RemoveAt(rowIndex);
            MessageBox.Show("Успешно", "Запись удалена");
        }

        private void searchEmployeeAdm_Click(object sender, EventArgs e)
        {

        }

        private void nuberWorkBook_Validating(object sender, CancelEventArgs e)
        {

        }

        private void lastName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
