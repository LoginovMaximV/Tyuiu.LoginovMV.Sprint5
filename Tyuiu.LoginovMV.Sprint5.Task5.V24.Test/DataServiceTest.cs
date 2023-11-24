using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint5.Task5.V24.Lib;
using System.IO;

namespace Tyuiu.LoginovMV.Sprint5.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Валерий\source\repos\Tyuiu.LoginovMV.Sprint5\DataSprint5\InPutDataFileTask5V24.txt";
            FileInfo file = new FileInfo(path);
            bool fileExist = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
