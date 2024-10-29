using System;

namespace CSharpTodoList.DAL.Contexts;

public class FileContext
{
    private static readonly string path = Directory.GetCurrentDirectory() + "/masterfile.txt";
    public static string ProjectListFile = File.ReadAllText(path);
    public static void Save(string content)
    {
        File.WriteAllText(path, content);
    }
}

