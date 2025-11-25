using System.IO;
using Tyuiu.DunaizevAO.Sprint5.Task3.V25.Lib;

namespace Tyuiu.DunaizevAO.Sprint5.Task3.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\pixel\source\repos\Tyuiu.DunaizevAO.Sprint5\Tyuiu.DunaizevAO.Sprint5.Task3.V25\bin\Debug\net8.0\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
