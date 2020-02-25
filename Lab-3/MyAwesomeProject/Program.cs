using System;
using System.Collections.Generic;

namespace MyAwesomeProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            using (var ctx = new MyContext())
            {
                Address addr = new Address() { Building_Number = "1", Street = "Privet Drive", Post_Code = "BL9 7SE", City = "Hull", People = new List<Person>() };

                Person jd = new Person() { First_Name = "Jane", Middle_Name = "Something", Last_Name = "Doe", Date_of_Birth = new DateTime(98, 09, 19), Address = addr };

                ctx.people.Add(jd);
                ctx.addresses.Add(addr);
                ctx.SaveChanges();

            }
        }
    }
}
