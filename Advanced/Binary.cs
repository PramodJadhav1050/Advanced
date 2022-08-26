using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Advanced
{
        public class Course
        {
            int id;
            string name;
            int fees;

            public int Id { get => id; set => id = value; }
            public string Name { get => name; set => name = value; }
            public int Fees { get => fees; set => fees = value; }
        }
        class Binary
        {
            static void FileToWrite(Course cs)
            {
                try
                {
                    FileStream fs = new FileStream(@"E:\C#\TestFolder\TextFile2", FileMode.Create, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(cs.Id);
                    bw.Write(cs.Name);
                    bw.Write(cs.Fees);
                    fs.Close();
                    bw.Close();
                    Console.WriteLine("File is create");
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            static void ReadFromFile()
            {
                try
                {
                    FileStream fs = new FileStream(@"E:\C#\TestFolder\TextFile2", FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    Console.WriteLine(br.ReadInt32());
                    Console.WriteLine(br.ReadString());
                    Console.WriteLine(br.ReadInt32());

                    br.Close();
                    fs.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            static void Main(string[] args)
            {
                //Write the data
                Course cs = new Course { Id = 1, Name = "Riya", Fees = 10000 };
                FileToWrite(cs);
                ReadFromFile();//Read the Data
                Console.ReadLine();
            }
        }
    
}

