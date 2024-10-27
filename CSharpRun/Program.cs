using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Collections.Frozen;
using CSharpTodoList.BAL;

namespace csharptodolist
{
    class Programm
    {
        static void Main(string[] args)
        {
            OperatorService os = new OperatorService();
            os.CreateProject(string.Join('\n', args));
            os.GetProject(3);
            os.GetProjects();
            os.DeleteProject(3);  
            os.GetProjects();
        }         

    }
}