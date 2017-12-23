using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Отель
{
    public enum accessLevels
    {
        user, admin  //Перечисление для проверки доступа
    };

    public class Authenticator
    {
        public string Password { get; set; }  //Создание автоматически реализуемого св-ва для пароля 
        public string UserName { get; set; }  //Создание автоматически реализуемого св-ва для пользователя
        public accessLevels Access { get; set; }       //Создание автоматически реализуемого св-ва для определения доступа типа перечислениея accessLevels
      //  public static string AccessCheck { get; set; }       //Костыль для проверки доступа
    }
}
