using CSharpTodoList.DAL;


namespace CSharpTodoList.BAL;

public class Operator
{
    public static void CreateProject(string text, string? path = null)
    {
        var writePath = path ?? Directory.GetCurrentDirectory() + "listprojects.txt";
        FileManager.WriteFile(text, writePath);
    }

    public static void DeleteProject()
    {

    }

    public static void CreateTask()
    {

    }

    public static void DeleteTask()
    {

    }

    public static void ChangeProjectName()
    {

    }

    public static void ChangeTaskName()
    {

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

