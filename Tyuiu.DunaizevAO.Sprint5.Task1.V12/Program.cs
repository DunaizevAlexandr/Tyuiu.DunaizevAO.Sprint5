using System.IO;
using Tyuiu.DunaizevAO.Sprint5.Task1.V12.Lib;

int start = -5;
int stop = 5;

DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("start = " + start);
Console.WriteLine("stop = " + stop);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(start,stop);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();