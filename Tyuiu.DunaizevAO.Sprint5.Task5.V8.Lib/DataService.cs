using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DunaizevAO.Sprint5.Task5.V8.Lib
{
    public class DataService : ISprint5Task5V8
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            string[] chis = str.Split( );
            double[] ch = new double[chis.Length];
            for (int i = 0; i < chis.Length; i++)
            {
                ch[i] = double.Parse(chis[i]);
            }
            double res = ch[0];


            for (int i = 1; i < ch.Length; i++)
            {
                if (ch[i] < ch[i-1])
                {
                    res = ch[i];
                }
            }
            return res;
        }
    }
}
