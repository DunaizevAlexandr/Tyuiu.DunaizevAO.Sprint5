using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DunaizevAO.Sprint5.Task7.V22.Lib
{
    public class DataService : ISprint5Task7V22
    {
        public string LoadDataAndSave(string path)
        {
            string path1 = File.ReadAllText(path);
            string pathsave = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V22.txt");
            FileInfo fileInfo = new FileInfo(pathsave);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathsave);
            }
            string res = "";
            foreach (char c in path1)
            {
                if (char.IsPunctuation(c))
                {
                    res += "#";
                }
                else
                {
                    res += c;
                }
            }
            File.WriteAllText(pathsave, res);
            return pathsave;
        }
    }
}
