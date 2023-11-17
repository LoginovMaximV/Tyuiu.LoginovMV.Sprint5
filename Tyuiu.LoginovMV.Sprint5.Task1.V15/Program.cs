using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint5.Task1.V15.Lib;

namespace Tyuiu.LoginovMV.Sprint5.Task1.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5| Выполнил: Логинов М.В | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                                  *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                                                    *");
            Console.WriteLine("* Задание #1                                                                                                 *");
            Console.WriteLine("* Вариант #15                                                                                                *");
            Console.WriteLine("* Выполнил: Логинов М.В   | ИИПб-23-2                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Дана функция, произвести табулирование на заданном диапазоне с шагом 1, результат сохранить в текстовый    *");
            Console.WriteLine("* файл OutPutFileTask1.txt и вывести на консоль. Округлить до двух знаков после запятой.                     *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Начало отрезка" + startValue);
            Console.WriteLine("Конец отрезка" + stopValue);
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл" + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
