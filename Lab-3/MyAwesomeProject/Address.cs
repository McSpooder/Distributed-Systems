using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MyAwesomeProject
{
    class Address
    {
        [Key]
        public int AddressIdentifier { get; set; }
        public string Building_Number { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Post_Code { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public ICollection<Person> People { get; set; }

        public Address() { }
    }
}
