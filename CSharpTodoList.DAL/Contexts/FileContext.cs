using System;

namespace CSharpTodoList.DAL.Contexts;

public class FileContext
{
    private readonly string path = Directory.GetCurrentDirectory() + "/masterfile.txt";
    //хоть убей пока не понимаю, почему это поле нуллабл. Где оно нуллабл?
    public string MasterFileContent = string.Empty;
    
    public FileContext()
    {
        if (!File.Exists(path))
        {
            File.Create(path).Close();
        }

        MasterFileContent = File.ReadAllText(path);          
    }

    public void Save(string content)
    {
        File.WriteAllText(path, content);
    }

}

