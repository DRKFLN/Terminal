using System;
using System.ComponentModel.Design;
using System.IO;

namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************");
            Console.WriteLine("*  Terminal  *");
            Console.WriteLine("**************");
            string command = " ", path = @"C:\";
            Console.WriteLine("Введите комманду");

            while (command != "exit" || command != "Exit")
            {
                Console.Write(path + "> ");;
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
                if (command == "cd" || command == "cd ")
                {
                    Console.Write("Укажите путь: ");
                    string way;
                    way = Console.ReadLine();
                    if (Directory.Exists(way))
                    {
                        path = way;
                        if (way == " ")
                        {
                            path = @"C:\";
                            break;
                        }
                    }
                    if(!Directory.Exists(way))
                    {
                        Console.WriteLine("Системе не удается найти указанный путь.");
                    }
                }
                if (command == "clear" || command == "cls")
                {
                    Console.Clear();
                }
                if (command == "exit" || command == "Exit")
                {
                    Environment.Exit(0);
                }
                if (command == "touch")
                {
                    Console.Write("укажите имя ");
                    string timeFile;
                    timeFile = Console.ReadLine();
                    FileInfo fi = new FileInfo(timeFile);
                    if (fi.Exists)
                    {
                        Console.WriteLine("Данный файл уже существует.");
                    }
                    else
                    {

                    }


                }
            }


        }
    }
}

