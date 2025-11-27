using System.IO;
using Tyuiu.DunaizevAO.Sprint5.Task6.V20.Lib;

string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V8.txt");

DataService ds = new DataService();
Console.WriteLine(ds.LoadFromDataFile(path));