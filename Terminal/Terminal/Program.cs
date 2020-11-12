using System;
using System.ComponentModel.Design;
using System.IO;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("**************");
            Console.WriteLine("*  Terminal  *");
            Console.WriteLine("**************");
            string command = " ", path = @"C:\", key;
            Console.WriteLine("Введите комманду");

            while (command != "exit" || command != "Exit")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("User> ");
                Console.ResetColor();
                command = Console.ReadLine();
                if (command == "ls")
                {
                    Console.WriteLine("Содержимое директории: " + path);
                    Console.WriteLine("Подкаталоги:");
                    string[] dirs = Directory.GetDirectories(path);
                    foreach (string s in dirs)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Файлы:");
                    string[] files = Directory.GetFiles(path);
                    foreach (string s in files)
                    {
                        Console.WriteLine(s);
                    }
                }
                if (command == "cd")
                {
                    Console.Write("Укажите путь: ");
                    string time;
                    time = Console.ReadLine();
                    FileInfo fi = new FileInfo(time);
                    if (fi.Exists)
                    {
                        path = time;
                    }
                    else
                    {
                        Console.WriteLine("Системе не удается найти указанный путь.");
                    }
                }
                if (command == "clear")
                {
                    Console.Clear();
                }
                if (command == "touch")
                {
                    Console.Write("укажите имя ");
                }
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
            }


        }
    }
}

