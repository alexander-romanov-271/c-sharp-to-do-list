using System.Data;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace CSharpTodoList.DAL.Contexts;

class FileContext : IDisposable
{
    protected StreamWriter? Conn {get; set;}
    public static StreamWriter Open(string? path = null, bool append = true)
    {
        string workingpath = path ?? Directory.GetCurrentDirectory() + "/projectslist.txt";
        Conn = new StreamWriter(workingpath, append);
        return Conn;
    }

    public void Dispose()
    {
        
    }
}
