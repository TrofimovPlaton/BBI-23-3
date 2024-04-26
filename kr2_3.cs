using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string userFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "m2306929");
        string solutionFolderPath = Path.Combine(userFolderPath, "Solution");

        if (!Directory.Exists(userFolderPath))
        {
            Directory.CreateDirectory(userFolderPath);
        }

        if (!Directory.Exists(solutionFolderPath))
        {
            Directory.CreateDirectory(solutionFolderPath);
        }

        CreateFile(solutionFolderPath, "cw2_1.json");

        CreateFile(solutionFolderPath, "cw2_2.json");

        Console.WriteLine("Файлы успешно созданы.");
    }

    static void CreateFile(string folderPath, string fileName)
    {
        string filePath = Path.Combine(folderPath, fileName);

        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
        }
        else
        {
            Console.WriteLine($"Файл {fileName} уже существует.");
        }
    }
}