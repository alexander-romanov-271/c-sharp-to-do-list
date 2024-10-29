using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Collections.Frozen;
using CSharpTodoList.DAL.UnitOfWork;

namespace csharptodolist
{
    class Programm
    {
        static void Main(string[] args)
        {
            UnitOfWork p = new UnitOfWork();
            Console.WriteLine(p.ProjectRepository._content);
        }         

    }
}