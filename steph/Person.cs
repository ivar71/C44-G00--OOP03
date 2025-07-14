using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steph
{
    internal class Person
    {
        public int age { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public Person(int id, string fname, string lname)
        {
            age = id;
            Fname = fname;
            Lname = lname;
        }
        public virtual string GetDetails()
        {
            return $"ID: [{age}], Name: [{Fname}], Email: [{Lname}]";
        }
    }
}
