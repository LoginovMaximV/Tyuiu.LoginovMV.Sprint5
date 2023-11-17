using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.LoginovMV.Sprint5.Task1.V15.Lib
{
    public class DataService : ISprint5Task1V15
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if(fileExists)
            {
                File.Delete(path);
            }
            double y;
            string Y;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((Math.Cos(x)) / (x - 0.4) + Math.Sin(x) * 8 * x + 2,2);
                Y = Convert.ToString(y);
                if (x != stopValue)
                {
                    File.AppendAllText(path, Y + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, Y);
                }
            }
            return path;

        }
    }
}
