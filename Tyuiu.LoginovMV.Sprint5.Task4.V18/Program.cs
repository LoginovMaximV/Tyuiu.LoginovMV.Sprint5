using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint5.Task4.V18.Lib;
using System.IO;

namespace Tyuiu.LoginovMV.Sprint5.Task4.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5| Выполнил: Логинов М.В | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                                  *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                                                    *");
            Console.WriteLine("* Задание #4                                                                                                 *");
            Console.WriteLine("* Вариант #18                                                                                                *");
            Console.WriteLine("* Выполнил: Логинов М.В   | ИИПб-23-2                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Создать папку в ручную С: DataSprint5 и скопировать в неё файл) в котором есть вещественное значение.      *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле, Вычислить значение по формуле                 *");
            Console.WriteLine("* (Полученное значение округлить до трёх знаков после запятой)                                               *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");
            string path = $@"{Directory.GetCurrentDirectory()}\DataSprint5\InPutDataFileTask4V18.txt";
            Console.WriteLine("Данные находятся в файле:" + path);
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
