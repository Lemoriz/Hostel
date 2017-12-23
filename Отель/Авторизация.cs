using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Отель
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {         
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            string UserName = userName.Text; // Присвоение из textbox в переменные
            string Password = password.Text;

            string text = File.ReadAllText("Passwords.txt");  //Открытие файла     

            JArray textJson = JsonConvert.DeserializeObject<JArray>(text); //Конвертация нашего текста в массив класса Json 

            var qq = textJson.FirstOrDefault(a => a.ToObject<Authenticator>().UserName == UserName); //Лямбда-функция для проверки на username(Берем все User name из класса Json и по очереди проверяем на совпадение с тем, что ввел пользователь )

            if (qq == null)
            {
                MessageBox.Show("Неверное имя пользователя или пароль", "Ошибка");
                return;
            }

            Authenticator auth = qq.ToObject<Authenticator>();

            if(auth.Password != Password) //Сравниваем пароли совпавших логинов 
            {
                MessageBox.Show("Неверное имя пользователя или пароль", "Ошибка");
                return;
            }
            MessageBox.Show("Добро пожаловать: " + auth.UserName, "Уровень доступа: " + auth.Access);

            if (auth.Access == accessLevels.admin)
            {
                new Otel().Show();
            }
            else
            {
                new Сотрудник().Show();
            }
            this.Hide();//Скрываем форму Авторизация

            //Authenticator.AccessCheck = Convert.ToString(auth.Access);//Записываем уровень доступа в AccessCheck
        }
    }


}
