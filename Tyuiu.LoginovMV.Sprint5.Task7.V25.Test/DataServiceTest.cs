using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint5.Task7.V25.Lib;
using System.IO;

namespace Tyuiu.LoginovMV.Sprint5.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Валерий\source\repos\Tyuiu.LoginovMV.Sprint5\DataSprint5\OutPutDataFileTask7V25.txt";
            FileInfo file = new FileInfo(path);
            bool fileExist = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
