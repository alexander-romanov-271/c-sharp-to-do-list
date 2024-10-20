using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Collections.Frozen;

namespace csharptodolist
{
    class Programm
    {
        static void Main(string[] args) {

            Console.WriteLine(Directory.GetCurrentDirectory());
            

            
          
            }         

        static Dictionary<string, string> ParseCmdArgs(string[] cmdArgs)
        {
            if (cmdArgs.Length == 0)
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

            foreach (string cmdArg in cmdArgs) {
                
                if (cmdArgsEnumerated.Count == 0) {

                    if (cmdArg[0] == '-' && allowedFlags.Contains(cmdArg)) {                        
                        cmdArgsEnumerated.Add(cmdArg, "");
                    }
                    
                    else {
                        Console.WriteLine($"Unknown command '{cmdArg}'. Please enter help to find available commands");
                        return new Dictionary<string, string>();
                    }
                }
                else {                    
                    if (cmdArg[0] == '-') {

                        if (allowedFlags.Contains(cmdArg)) {
                            cmdArgsEnumerated.Add(cmdArg, "");
                        }
                        else {
                            Console.WriteLine($"Unknown command '{cmdArg}'. Please enter help to find available commands");
                            return new Dictionary<string, string>();
                        }              
                    }

                    else {
                        string lastKey = cmdArgsEnumerated.Keys.ElementAt(^1);
                        if (cmdArgsEnumerated[lastKey] == "") {
                            cmdArgsEnumerated[lastKey] = cmdArg;
                        }
                        else {
                            Console.WriteLine($"Unknown command '{cmdArg}'. Please enter help to find available commands");
                            return new Dictionary<string, string>();
                        }
                    }
                }
            }

            return cmdArgsEnumerated;
        }
    }
    }

    class Operator {

        public Dictionary<string, string> readToDoListsFile()
        {
            return new Dictionary<string, string>();
        }

        public bool CheckAvailableToDoLists(string[] todolists) 
        {
            string toDoListsStorage = Directory.GetCurrentDirectory() + "todolists.txt";

            if (Path.Exists(toDoListsStorage))
            {
                
            }
            return todolists.Length == 0;
        }

        
    }
    


    class ToDoListFile
    {
        public string path = "";

        void printTasks()
        {
            using (StreamReader sr = new StreamReader(this.path)) {
                sr.ReadToEnd();
            };
            
        }

        static void addTask()
        {

        }

        static void removeTask()
        {
            
        }

        static void clearToDoList()
        {

        }
    }



