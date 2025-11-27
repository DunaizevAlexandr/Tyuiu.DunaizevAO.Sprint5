using System.IO;
using Tyuiu.DunaizevAO.Sprint5.Task5.V8.Lib;

string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V8.txt");

DataService ds = new DataService();
Console.WriteLine(ds.LoadFromDataFile(path));