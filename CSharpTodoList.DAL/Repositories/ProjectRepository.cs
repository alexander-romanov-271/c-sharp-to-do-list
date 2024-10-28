using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using CSharpTodoList.DAL.Models;

namespace CSharpTodoList.DAL.Repositories;

public class ProjectRepository : IRepository<ProjectModel>
{
    
    private List<string> _content;
    public ProjectRepository(List<string> content)
    {
        _content = content;
    }
    public void Create(ProjectModel item)
    {
        _content.Add(item);
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
        ProjectModel item = _content[id - 1];
    }

    public IEnumerable<ProjectModel> GetItemList()
    {
        _content;
    }

    public void Update(ProjectModel item)
    {
        item = 
    }
}
