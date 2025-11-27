using System.IO;
using Tyuiu.DunaizevAO.Sprint5.Task4.V29.Lib;

string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V29.txt");

DataService ds = new DataService();
Console.WriteLine(ds.LoadFromDataFile(path));