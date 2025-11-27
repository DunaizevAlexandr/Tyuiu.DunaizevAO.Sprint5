using System.IO;
using Tyuiu.DunaizevAO.Sprint5.Task7.V22.Lib;


DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");


string pathsave = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V22.txt");
string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V22.txt");

Console.WriteLine("Данные находятся в файле: " + path);


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");


var res = ds.LoadDataAndSave(path);

Console.WriteLine(File.ReadAllText(res));
Console.WriteLine("Находится в файле: " + res);