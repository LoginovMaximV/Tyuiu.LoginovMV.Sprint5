using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.LoginovMV.Sprint5.Task2.V12.Lib
{
    public class DataService : ISprint5Task2V12
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            if(fileExist)
            {
                File.Delete(path);
            }
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            string b = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j != m - 1)
                    {
                        b = b + matrix[i, j] + ";";
                    }
                    else
                    {
                        b = b + matrix[i, j];
                    }
                }
                if (i != n - 1)
                {
                    File.AppendAllText(path, b + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, b);
                }
                b = "";
            }
            return path;
        }
    }
}
