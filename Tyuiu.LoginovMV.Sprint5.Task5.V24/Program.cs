using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint5.Task5.V24.Lib;

namespace Tyuiu.LoginovMV.Sprint5.Task5.V24
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
            Console.WriteLine("* Задание #5                                                                                                 *");
            Console.WriteLine("* Вариант #24                                                                                                *");
            Console.WriteLine("* Выполнил: Логинов М.В   | ИИПб-23-2                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Создать папку в ручную С: DataSprint5 и скопировать в неё файл) в котором есть набор значений.             *");
            Console.WriteLine("* Найти сумму всех двузначных целых чисел в файле.  Полученный результат вывести на консоль.                 *");
            Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.                                            *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");
            string path = @"C:\Users\Валерий\source\repos\Tyuiu.LoginovMV.Sprint5\DataSprint5\InPutDataFileTask5V24.txt";
            Console.WriteLine("Данные находятся в файле:" + path);
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Сумма двузначных элементов в файле = "+res);
            Console.ReadKey();
        }
    }
}
