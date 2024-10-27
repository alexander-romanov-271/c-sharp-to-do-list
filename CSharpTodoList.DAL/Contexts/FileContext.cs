using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using CSharpTodoList.DAL.Models;
using Microsoft.VisualBasic;

namespace CSharpTodoList.DAL.Contexts;

class FileContext : StreamWriter
{
    public FileContext(string path, bool append = true): base(path, append) {}

    public void Create(string message)
    {
        WriteLine(message);
    }


    public bool CheckConn()
    {
        if (Conn is null)
        {
            return false;
        }

        return true;
    }

    public string? ConvertToString(BaseModel item)
    {
        PropertyInfo[] props = item.GetType().GetProperties();

        Dictionary<string, string> proj = new Dictionary<string, string>();
        

        foreach (PropertyInfo prop in props)
        {   
            string name = prop.Name;
            var val = prop.GetValue(item, null);

            if (val is not null)
            {
                proj.Add(name, val.ToString() ?? "");
            }
            else
            {
                proj.Add(name, "");
            }
        }

        string returnString = "{";

        foreach (string name in proj.Keys)
        {
            returnString += name + ": " + proj[name];
        }

        returnString += "}";

        return returnString;

    }

    public void Add(string? text = "empty line")
    {
        if (Conn is not null)
        {
            Conn.WriteLine(text);
        }
        else
        {
            Console.WriteLine("The Connection is null. Method Add");
        }
    }
    

    public void Dispose()
    {
        if (Conn is null)
        {
            Console.WriteLine("No underliing stream");
            return;
        }
        Conn.Dispose();
    }
}


