using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced.LINQ
{
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"{Id} -> {Name} -> {Salary} -> {City}";
        }
    }
    public class Employee
    {
        static void Main(string[] args)
        {
            List<Emp> Employee = new List<Emp>()
            {
                new Emp{Id=1, Name="Pramod",Salary=25000,City="Pune"},
                new Emp{Id=2, Name="Pravin",Salary=35000,City="Mumbai"},
                new Emp{Id=3, Name="Pradip",Salary=15000,City="nashik"},
                new Emp{Id=4, Name="Raj",Salary=55000,City="Pune"},
                new Emp{Id=5, Name="Sham",Salary=35000,City="Delhi"},
                new Emp{Id=6, Name="Priyanka",Salary=25000,City="Mumbai"},
                new Emp{Id=7, Name="Snehal",Salary=65000,City="Pune"},
                new Emp{Id=8, Name="Mayuri",Salary=85000,City="Nashik"},

            };
            // Display all employee
            var result1 = from E in Employee
                          select E;
            //lambda
            var res1 =Employee.ToList();

            //Display employee whose salary is > 25000
            var result2 = from E in Employee
                          where E.Salary > 25000
                          select E;
            //lambda
            var res2 = Employee.Where(e => e.Salary > 25000).ToList();

            // Display employee whose name start with P. 
            var result3 = from E in Employee
                          where E.Name.StartsWith("P")
                          select E;
            //lambda
            var res3 = Employee.Where(e => e.Name.StartsWith("P")).ToList();

            // Dispaly employee with asending order by name
            var result4 = from E in Employee
                          orderby E.Name
                          select E;
            //lambda
            var res4 = Employee.OrderBy(e => e.Name).ToList();

            //  Dispaly employee with desending order by salary
            var result5 = from E in Employee
                          orderby E.Salary descending
                          select E;
            //lambda
            var res5 = Employee.OrderByDescending(e => e.Salary).ToList();

            // Dispaly employee whose from "Pune" city.
            var result6 = from E in Employee
                          where E.City.Contains ("Pune")
                          select E;
            //lambda
            var res6 = Employee.Where(e => e.City.Contains("Pune")).ToList();

            // Dispaly employee whose salary is >25000 & emp is from "Mumbai" city.
            var result7 = from E in Employee
                          where E.Salary > 25000 & E.City.Contains("Mumbai")
                          select E;
            //lambda
           var res7 = Employee.Where(e => e.Salary > 25000 && e.City == ("Mumbai")).ToList();


            foreach (Emp item in res7)
            {
                Console.WriteLine(item);
            }

        }
    }
}


