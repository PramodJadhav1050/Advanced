using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Advanced
{
    internal class DirectoryDemo
    {
        static void CreateFolder()
        {
            string path = @"E:\C#\TestFolder1";
            DirectoryInfo d = new DirectoryInfo(path);
            if (d.Exists)
            {
                Console.WriteLine("Folder is already created");
            }
            else
            {
                d.Create();
                Console.WriteLine("Folder is created");
            }
        }
        static void CreateFile()
        {
            string path = @"E:\C#\TestFolder1\TestFile1.txt";
            FileInfo f = new FileInfo(path);
            if (f.Exists)
            {
                Console.WriteLine("File already exits");
            }
            else
            {
                f.Create();
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
