using System;
using System.Collections.Generic;
using System.Text;

namespace MyAwesomeProject
{
    class Person
    {
        public string PersonID { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public DateTime Date_of_Birth { get; set; }
        public Address Address { get; set; }

        public Person() { }
    }
}
