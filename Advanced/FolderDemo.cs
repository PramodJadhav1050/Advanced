using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Advanced
{
    internal class FolderDemo
    {
        static void CreateFolder()
        {
            string path = @"E:\C#\TestFolder";
            if (Directory.Exists(path))
            {
                Console.WriteLine("Folder is already created");
            }
            else
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Folder is created");
            }
        }
        static void CreateFile()
        {
            string path = @"E:\C#\TestFolder\TestFile.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File already exits");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("File created");
            }

        }
        static void Main(string[] args)
        {
            CreateFolder();
            CreateFile();
        }

    }
}
