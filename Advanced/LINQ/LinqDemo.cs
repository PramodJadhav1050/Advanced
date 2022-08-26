using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.LINQ
{
    public class product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string CompanyName { get; set; }

        public override string ToString()
        {
            return $"{Id} -> {Name} -> {Price} -> {CompanyName}";
        }
    }
    public class LinqDemo
    {
        static void Main(string[] args)
        {
            List<product> products = new List<product>()
            {
                new product{Id=1, Name="Mouse",Price=799,CompanyName="Dell"},
                new product{Id=2, Name="laptop",Price=43799,CompanyName="Dell"},
                new product{Id=3, Name="Mouse",Price=659,CompanyName="intex"},
                new product{Id=4, Name="keyboard",Price=999,CompanyName="Dell"},
                new product{Id=5, Name="Mouse",Price=899,CompanyName="lenovo"},
                new product{Id=6, Name="keyboard",Price=599,CompanyName="lenovo"},
                new product{Id=7, Name="laptop",Price=67799,CompanyName="lenovo"},
                new product{Id=8, Name="speaker",Price=1799,CompanyName="Dell"},
                new product{Id=9, Name="Ram",Price=3799,CompanyName="Microsoft"},
                new product{Id=10, Name="charger",Price=2199,CompanyName="Dell"},

            };

            var result1 = from p in products
                          select p;

            var result2 = from p in products
                          where p.Price < 2000
                          select p;

            var result3 = from p in products
                          where p.Price > 2000 && p.Price < 3000
                          select p;

            var result4 = from p in products
                          where p.CompanyName.StartsWith("D")
                          select p;
            var result5 = from p in products
                          where p.CompanyName.EndsWith("o")
                          select p;
            var result6 = from p in products
                          where p.CompanyName.Contains("m") || p.CompanyName.Contains("M")
                          select p;
            var result7 = from p in products
                          where p.Price <  2500
                          orderby p.Price
                          select p;

            foreach (product item in result7)
            {
                Console.WriteLine(item);
            }

        }
    }
}

