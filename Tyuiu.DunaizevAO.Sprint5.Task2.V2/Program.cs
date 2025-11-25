using System.IO;
using Tyuiu.DunaizevAO.Sprint5.Task2.V2.Lib;

int[,] matr = new int[3, 3] { { -7, 7, 5 }, { 4, 2, -7 }, { 2, 6, -4 } };

DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(matr);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(matr);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();