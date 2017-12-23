using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Отель
{
    public struct Bio //Структура для работы с данными клиентов
    {
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public string Должность { get; set; }
        public string Серия_паспорта { get; set; }
        public string Номер_паспорта { get; set; }
        public string Дата_выдачи { get; set; }
        public string Пол { get; set; }
        public string Страховой_номер { get; set; }
        public string Семейное_положение { get; set; }
        public string Фактический_адрес_проживания { get; set; }
        public string Серия_рудовой_книжки { get; set; }
        public string Номер_трудовой_книжки { get; set; }
        public string Вкладыш { get; set; }
        public string Гражданство { get; set; }
    }
}
