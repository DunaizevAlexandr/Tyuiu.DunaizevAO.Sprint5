using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DunaizevAO.Sprint5.Task4.V29.Lib
{
    public class DataService : ISprint5Task4V29
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            str = str.Replace('.', ',');
            double x = double.Parse(str);
            double y = (x) / (2 * x) + Math.Sin(Math.Pow(x, 2));
            double y = Math.Round(y, 3);
            return y;
        }
    }
}
