using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Advanced
{
    internal class Stream
    {
        static void WriteToFilestream()
        {
            try
            {
                FileStream fs = new FileStream(@"E:\C#\TestFolder\TextDoc.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("This is Sample text in the File");
                sw.Close();
                sw.Close();
                Console.WriteLine("Done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void ReadFromUsingstream()
        {
            try
            {
                FileStream fs = new FileStream(@"E:\C#\TestFolder\TextDoc.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            WriteToFilestream();
            ReadFromUsingstream();
            
        }
    }
}

