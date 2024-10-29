using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using CSharpTodoList.DAL.Models;
using Microsoft.VisualBasic;
using CSharpTodoList.DAL.Repositories;
using CSharpTodoList.DAL.Contexts;

namespace CSharpTodoList.DAL.UnitOfWork;

public class UnitOfWork
{
    private readonly string fileContext = FileContext.ProjectListFile;
    private ProjectRepository projectRepository
    {
        get
        {
            return projectRepository ?? new ProjectRepository(fileContext);
        }
    }
}


