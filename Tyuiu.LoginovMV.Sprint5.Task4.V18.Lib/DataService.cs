using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.LoginovMV.Sprint5.Task4.V18.Lib
{
    public class DataService : ISprint5Task4V18
    {
        public double LoadFromDataFile(string path)
        {
            string aboba = File.ReadAllText(path);
            string boba = aboba.Replace('.', ',');
            double x = Convert.ToDouble(boba);
            double res = Math.Round(Math.Cos(x) + (Math.Pow(x, 2) / 2),3);
            return res;
        }
    }
}
