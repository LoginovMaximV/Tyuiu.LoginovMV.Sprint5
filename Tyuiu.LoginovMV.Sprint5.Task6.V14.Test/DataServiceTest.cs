using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint5.Task6.V14.Lib;
using System.IO;

namespace Tyuiu.LoginovMV.Sprint5.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Валерий\source\repos\Tyuiu.LoginovMV.Sprint5\DataSprint5\InPutDataFileTask6V14.txt";
            int res = ds.LoadFromDataFile(path);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string path = @"C:\Users\Валерий\source\repos\Tyuiu.LoginovMV.Sprint5\DataSprint5\InPutDataFileTask6V14.txt";
            FileInfo file = new FileInfo(path);
            bool fileExist = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
