using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DunaizevAO.Sprint5.Task5.V8.Lib
{
    public class DataService : ISprint5Task5V8
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            string[] chis = str.Split();
            double res = double.Parse(chis[0]);
            for (int i = 1; i < chis.Length; i++)
            {
                if (double.Parse(chis[i]) < double.Parse(chis[i-1]))
                {
                    res = double.Parse(chis[1]);
                }
            }
            return res;
        }
    }
}
