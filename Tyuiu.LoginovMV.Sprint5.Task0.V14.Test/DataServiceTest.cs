using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint5.Task0.V14.Lib;
using System.IO;

namespace Tyuiu.LoginovMV.Sprint5.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Валерий\source\repos\Tyuiu.LoginovMV.Sprint5\Tyuiu.LoginovMV.Sprint5.Task0.V14\bin\debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
