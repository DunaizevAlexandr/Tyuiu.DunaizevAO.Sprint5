using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DunaizevAO.Sprint5.Task1.V12.Lib
{
    public class DataService : ISprint5Task1V12
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            string result = "";

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;

                
                if (Math.Sin(x) == 2)
                {
                    y = 0;
                }
                else
                {
                    y = ((5 * x + 2.5) / (Math.Sin(x) - 2)) + 2 ;
                    y = Math.Round(y, 2);
                }

                result += y.ToString("F2").Replace(',', '.');
                File.AppendAllText(path, result);
            }

            return path;
        }
    }
}