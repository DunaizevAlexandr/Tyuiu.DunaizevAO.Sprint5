using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DunaizevAO.Sprint5.Task0.V15.Lib
{
    public class DataService : ISprint5Task0V15
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double y = (x) / (x * x * x + 2);
            y = Math.Round(y,3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
