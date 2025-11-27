using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DunaizevAO.Sprint5.Task6.V20.Lib
{
    public class DataService : ISprint5Task6V20
    {
        public int LoadFromDataFile(string path)
        {
            string path1 = File.ReadAllText(path);
            path1 = path1.Replace('.', ' ');
            string[] str = path1.Split(' ');
            int res = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length == 6)
                {
                    res++;
                }
            }
            return res;
        }
    }
}
