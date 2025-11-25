using System.IO;
using Tyuiu.DunaizevAO.Sprint5.Task2.V2.Lib;

namespace Tyuiu.DunaizevAO.Sprint5.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\pixel\source\repos\Tyuiu.DunaizevAO.Sprint5\Tyuiu.DunaizevAO.Sprint5.Task2.V2\bin\Debug\net8.0\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
