using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DunaizevAO.Sprint5.Task2.V2.Lib
{
    public class DataService : ISprint5Task2V2
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[i, j] >= 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            string str = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j<2)
                    {
                        str += matrix[i, j] + ";";
                    }
                    if (j==2)
                    {
                        str += matrix[i, j];
                    }
                }
                if (i<2)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                if (i==2)
                {
                    File.AppendAllText(path, str);
                }
            }
            return path;
        }
    }
}
