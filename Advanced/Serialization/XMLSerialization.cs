using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Advanced.Serialization
{
    [Serializable]
    public class Product1
    {
        int productid;
        string productname;
        int price;

        public int Productid { get => productid; set => productid = value; }
        public string Productname { get => productname; set => productname = value; }
        public int Price { get => price; set => price = value; }
    }
    class  XMLSerialization
    {
        static void XmlSerializationWrite(Product1 prod)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\C#\TestFolder\XmlFileAssignment.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Product1));
                xs.Serialize(fs, prod);
                Console.WriteLine("Xml data added");
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void XmlSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"E:\C#\TestFolder\XmlFileAssignment.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Product1));
                Product1 prod = (Product1)xs.Deserialize(fs);
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
            Product1 prod = new Product1 { Productid = 2, Productname = "Mobile", Price = 20000 };
            XmlSerializationWrite(prod);
            XmlSerializationRead();
            Console.ReadLine();
        }
    }
}
