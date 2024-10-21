using System.Collections.Immutable;
using System.IO;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace CSharpTodoList.DAL;

public class FileManager
{
    public static void WriteFile(string text, string path, bool append = true)
    {
        using (StreamWriter sw = new StreamWriter(path, append))
        {
            sw.WriteLine(text);
        }
    }

    public static string ReadFile(string path)
    {
        using (StreamReader sr = new StreamReader(path))
        {
            string text = sr.ReadToEnd();
            return text;
        }
    }
}
