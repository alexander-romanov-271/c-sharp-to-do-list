using CSharpTodoList.DAL.Models;


namespace CSharpTodoList.BAL;

public class OperatorService
{
    public string Path {get; set;}

    public OperatorService(string? path = null)
    {
        var workingPath = path ?? Directory.GetCurrentDirectory() + "projectlist.txt";         
        Path = workingPath;
    }

    public void CreateProject(string contents)
    {
        File.AppendAllText(this.Path, contents + "\n");
    }

    public void GetProjects()
    {
        Console.WriteLine(File.ReadAllText(this.Path));
    }

    public void GetProject(int id)
    {
        string[] projectList = File.ReadAllText(this.Path).Split('\n');
        Console.WriteLine(projectList[id - 1]);
    }

    public void DeleteProject(int id)
    {
        List<string> projectList = File.ReadAllText(this.Path).Split('\n').ToList();
        List<string> newProjectList = [];

        int i = 0;
        while (i < projectList.ToArray().Length - 1)
        {
            if (i != id - 1)
            {
                newProjectList.Add(projectList[i]);
            }
            i++;
        }

        File.WriteAllText(this.Path, string.Join('\n', newProjectList) + "\n");
    }
  

}


public class CommandLineArgumentsParser
{
    public static Dictionary<string, string> ParseArguments(string[] cmdarguments)
    {
        if (cmdarguments.Length == 0)
        {
            Console.WriteLine("To-Do List app. Version = 1.0. Please enter 'help' to find available commands.");
            return new Dictionary<string, string>();
        }

        string[] allowedFlags = [
            "-add", //add new task to ToDoList
            "-remove", //remove a task from ToDoList
            "-clear", //clear all tasks in ToDoList
            "-show", // show all tasks from ToDoList
            "-help"
            ];

                    
        Dictionary<string, string> cmdArgsEnumerated = new Dictionary<string, string>();

        foreach (string cmdArg in cmdarguments) 
        {            
            if (cmdArgsEnumerated.Count == 0) 
            {
                if (cmdArg[0] == '-' && allowedFlags.Contains(cmdArg)) 
                {                        
                    cmdArgsEnumerated.Add(cmdArg, "");
                }
                
                else 
                {
                    Console.WriteLine($"Unknown command '{cmdArg}'. Please enter help to find available commands");
                    return new Dictionary<string, string>();
                }
            }

            else 
            {                    
                if (cmdArg[0] == '-') 
                {

                    if (allowedFlags.Contains(cmdArg)) 
                    {
                        cmdArgsEnumerated.Add(cmdArg, "");
                    }
                    else 
                    {
                        Console.WriteLine($"Unknown command '{cmdArg}'. Please enter help to find available commands");
                        return new Dictionary<string, string>();
                    }              
                }

                else 
                {
                    string lastKey = cmdArgsEnumerated.Keys.ElementAt(^1);
                    if (cmdArgsEnumerated[lastKey] == "") 
                    {
                        cmdArgsEnumerated[lastKey] = cmdArg;
                    }
                    else 
                    {
                        Console.WriteLine($"Unknown command '{cmdArg}'. Please enter help to find available commands");
                        return new Dictionary<string, string>();
                    }
                }
            }
        }
        
        return cmdArgsEnumerated;
    }
}

