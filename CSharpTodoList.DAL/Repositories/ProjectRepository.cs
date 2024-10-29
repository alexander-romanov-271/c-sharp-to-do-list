using System;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using CSharpTodoList.DAL.Models;
using Utils;

namespace CSharpTodoList.DAL.Repositories;

public class ProjectRepository(string content)
 { 
    private string _content = content;
    /*public ProjectRepository(List<string> content)
    {
        _content = content;
    }
    public void Create(ProjectModel item)
    {
        if (item == null)
        {
            Console.WriteLine("item is null");
            return;
        }
        _content.Add(Utilities.TypeToString(item) ?? string.Empty);
    }

    public void Delete(int id)
    {
        _content.RemoveAt(id - 1);
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public ProjectModel GetItem(int id)
    {
        ProjectModel item = new ProjectModel(Utilities.StringToDict(_content[id - 1]));
        return item;
    }

    public IEnumerable<ProjectModel> GetItemList()
    {
        List<ProjectModel> l = [];
        foreach (string s in _content)
        {
            l.Add(new ProjectModel(Utilities.StringToDict(s)));
        }
        return l;
    }

    public void Update(ProjectModel item)
    {
        throw new NotImplementedException();
    }*/
}
