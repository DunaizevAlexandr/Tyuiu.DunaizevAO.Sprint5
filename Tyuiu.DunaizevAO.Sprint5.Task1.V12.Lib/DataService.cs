using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DunaizevAO.Sprint5.Task1.V12.Lib
{
    public class DataService : ISprint5Task1V12
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            int count = stopValue - startValue + 1;
            string[] lines = new string[count];

            for (int i = 0; i < count; i++)
            {
                int x = startValue + i;
                double denominator = Math.Sin(x) - 2;
                double value;

                if (denominator == 0)
                {
                    value = 0;
                }
                else
                {
                    value = (5 * x + 2.5) / denominator;
                    value = Math.Round(value, 2);
                }

                lines[i] = $"{value:F2}".Replace(',', '.');
            }

            File.WriteAllLines(path, lines);
            return path;
        }
    }
}