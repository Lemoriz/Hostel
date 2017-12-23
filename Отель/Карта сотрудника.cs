using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Отель
{
    public partial class Карта_сотрудника : Form
    {
        int idx;
        public Карта_сотрудника()
        {

        }


        public Карта_сотрудника(int index, accessLevels f)
        {
            InitializeComponent();

            if (f == accessLevels.user)
            {
                this.lastName.ReadOnly = true;
                this.firstName.ReadOnly = true;
                this.midlleName.ReadOnly = true;
                this.series.ReadOnly = true;
                this.dateIssue.Enabled = false;
                this.number.ReadOnly = true;
                this.sex.Enabled = false;
                this.insurance.ReadOnly = true;
                this.famileStatus.Enabled = false;
                this.homeAddress.ReadOnly = true;
                this.seriesWorkBook.ReadOnly = true;
                this.nuberWorkBook.ReadOnly = true;
                this.insertionWorkBook.ReadOnly = true;
                this.citizenShip.ReadOnly = true;
                this.position.ReadOnly = true;
                this.button1.Visible = false;
 
            }
            else
            {
                this.button2.Visible = false;
                this.lastName.HidePromptOnLeave = true;
                this.firstName.HidePromptOnLeave = true;
                this.midlleName.HidePromptOnLeave = true;
                this.position.HidePromptOnLeave = true;
                this.citizenShip.HidePromptOnLeave = true;
            }

            Bio input = WorkWithFile.jArray[index].ToObject<Bio>();
            idx = index;
            {
                position.Text = input.Должность;
                firstName.Text = input.Имя;
                lastName.Text = input.Фамилия;
                midlleName.Text = input.Отчество;
                series.Text = input.Серия_паспорта;
                dateIssue.Text = input.Дата_выдачи;
                number.Text = input.Номер_паспорта;
                sex.Text = input.Пол;
                insurance.Text = input.Страховой_номер;
                famileStatus.Text = input.Семейное_положение;//sadsadsad
                homeAddress.Text = input.Фактический_адрес_проживания;
                seriesWorkBook.Text = input.Серия_рудовой_книжки;
                nuberWorkBook.Text = input.Номер_трудовой_книжки;
                insertionWorkBook.Text = input.Вкладыш;
                citizenShip.Text = input.Гражданство;
            };
        }

        private void Карта_сотрудника_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           // if (Convert.ToString(Authenticator.AccessCheck) == "admin")
            //{
                if(Convert.ToDateTime(dateIssue.Text) <= DateTime.Now)
            {
                    WorkWithFile.jArray[idx] = JToken.FromObject(new Bio
                    {
                        Должность = position.Text,
                        Имя = firstName.Text,
                        Фамилия = lastName.Text,
                        Отчество = midlleName.Text,
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
                    });
                    WorkWithFile.SaveArray("Employee.txt");
                    MessageBox.Show("Изменения сохранены!", "Успешно");
                }
            else MessageBox.Show("Дата не может быть больше сегодняшней", "Ошибка!");
            //}
            //else MessageBox.Show("У вас нет прав доступа", "Ошибка!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lastName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
