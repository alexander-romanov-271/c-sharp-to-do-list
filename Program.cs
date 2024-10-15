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

            Dictionary<string, string> cmdArgunemts = ParseCmdArgs(args); 

            foreach (var el in cmdArgunemts) {
                Console.WriteLine($"{el.Key} : {el. Value}");
            }
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
                "-show", // show all tsks from ToDoList
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

        static void getPathToFile()
        {

        }
    }

    class ToDoListRememberer {

        string path = "";
        
    }

    class Operator {

        string[] listOfToDoLists = [];

        public bool checkAvailableToDoLists() 
        {
            return listOfToDoLists.Length == 0;
        }
        

        public Dictionary<string, string> readToDoListsFile()
        {
            return new Dictionary<string, string>();
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
}

