using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.LoginovMV.Sprint5.Task7.V25.Lib
{
    public class DataService : ISprint5Task7V25
    {
        public string LoadDataAndSave(string path)
        {
            string savepath = @"C:\Users\Валерий\source\repos\Tyuiu.LoginovMV.Sprint5\DataSprint5\OutPutDataFileTask7V25.txt";
            FileInfo file = new FileInfo(savepath);
            bool fileExist = file.Exists;
            if(fileExist)
            {
                File.Delete(savepath);
            }
            string str = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (((line[i]>='a')&&(line[i]<='z'))|| ((line[i] >= 'A') && (line[i] <= 'Z')))
                        {
                            continue;
                        }
                        else
                        {
                            str = str + line[i];
                        }
                    }
                    File.AppendAllText(savepath, str + Environment.NewLine);
                    str = "";
                }
            }
            return savepath;
        }
    }
}
