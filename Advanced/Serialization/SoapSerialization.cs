using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Advanced.Serialization
{
    [Serializable]
    public class Product2
    {
        int productid;
        string productname;
        int price;

        public int Productid { get => productid; set => productid = value; }
        public string Productname { get => productname; set => productname = value; }
        public int Price { get => price; set => price = value; }
    }
    class SoapSerializationAssignment
    {
        static void SoapSerializationWrite(Product2 prod)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\C#\TestFolder\SoapFile.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, prod);
                Console.WriteLine("Soap data added");
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void SoapSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"E:\C#\TestFolder\SoapFile.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                Product2 prod = (Product2)sf.Deserialize(fs);
                Console.WriteLine(prod.Productid);
                Console.WriteLine(prod.Productname);
                Console.WriteLine(prod.Price);
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            Product2 prod = new Product2 { Productid = 3, Productname = "Active 5G", Price = 60000 };
            SoapSerializationWrite(prod);
            SoapSerializationRead();
            Console.ReadLine();
        }
    }
}