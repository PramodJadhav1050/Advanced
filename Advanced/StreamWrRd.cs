using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Advanced
{
    internal class StreamWrRd
    {
        static void WriteToFileUsingStream()
        {
            try
            {
                FileStream fs = new FileStream(@"E:\C#\TestFolder\TestFile", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("This is sample text in the file");
                sw.Close();
                fs.Close();
                Console.WriteLine("Done");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void ReadFromFileUsingStream()
        {
            try
            {
                FileStream fs = new FileStream(@"E:\C#\TestFolder\TestFile", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            WriteToFileUsingStream();
            ReadFromFileUsingStream();
        }

    }
}
