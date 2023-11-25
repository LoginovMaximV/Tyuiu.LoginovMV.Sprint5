using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint5.Task6.V14.Lib;
using System.IO;

namespace Tyuiu.LoginovMV.Sprint5.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5| Выполнил: Логинов М.В | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                                  *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                                                           *");
            Console.WriteLine("* Задание #6                                                                                                 *");
            Console.WriteLine("* Вариант #14                                                                                                *");
            Console.WriteLine("* Выполнил: Логинов М.В   | ИИПб-23-2                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Создать папку в ручную С: DataSprint5 и скопировать в неё файл) в котором есть набор значений.             *");
            Console.WriteLine("* в котором есть набор символьных данных.Найти количество знаков препинания в заданной строке.               *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");
            string path = @"C:\Users\Валерий\source\repos\Tyuiu.LoginovMV.Sprint5\DataSprint5\InPutDataFileTask6V14.txt";
            Console.WriteLine("Данные находятся в файле:" + path);
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Количество знаков препинания = " + res);
            Console.ReadKey();
        }
    }
}
