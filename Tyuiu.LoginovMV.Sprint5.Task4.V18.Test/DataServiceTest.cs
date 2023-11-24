using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint5.Task4.V18.Lib;
using System.IO;

namespace Tyuiu.LoginovMV.Sprint5.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Валерий\source\repos\Tyuiu.LoginovMV.Sprint5\Tyuiu.LoginovMV.Sprint5.Task4.V18\bin\debug\DataSprint5\InPutDataFileTask4V18.txt";
            FileInfo file = new FileInfo(path);
            bool fileExist = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);

        }
    }
}
