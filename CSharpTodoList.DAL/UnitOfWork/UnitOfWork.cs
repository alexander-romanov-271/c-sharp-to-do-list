using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using CSharpTodoList.DAL.Models;
using Microsoft.VisualBasic;
using CSharpTodoList.DAL.Repositories;

namespace CSharpTodoList.DAL.UnitOfWork;

public class UnitOfWork
{
    private string _path;
    private List<string> _content;
    private ProjectRepository projectRepository
    {
        get
        {
            return projectRepository ?? new ProjectRepository(_content);
        }
    }

    public UnitOfWork(string? path)
    {
        _path = path ?? Directory.GetCurrentDirectory() + "/projectslist.txt";
        _content = File.ReadAllLines(_path).ToList();
    }

    public void Save()
    {
        File.AppendAllLines(_path, _content);
    }

    public void Dispose()
    {
    }
}


