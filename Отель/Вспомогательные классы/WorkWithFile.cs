using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Отель
{
    class WorkWithFile //Класс для работы с файлом
    {

        public static JArray jArray = null; // JArray класс для работы с массивами Json-а

        public static void LoadArray(string path) //Функция для загрузки в массив из файла
        {
            var file = File.Open(path, FileMode.OpenOrCreate, FileAccess.Read);//Открытие файла на чтение

            StreamReader stream = new StreamReader(file);

            jArray = JsonConvert.DeserializeObject<JArray>(stream.ReadToEnd());//Заполняем в массив Json - a
            if (jArray == null)
                jArray = new JArray();

            stream.Close();
        }

        public static void SaveArray(string path) // Запись изменений в файл
        {
            StreamWriter stream = new StreamWriter(File.Open(path, FileMode.Truncate, FileAccess.Write));
            var w = JsonConvert.SerializeObject(jArray, Formatting.Indented);
            stream.Write(w);
            stream.Close();
        }
    }
}
