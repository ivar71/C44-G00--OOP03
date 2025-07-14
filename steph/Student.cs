using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steph
{
    internal class Student : Person
    {
        public int Gradelvl { get; set; }

        public Student(int age, string Lname, string Fname, int gradeLevel) : base(age, Fname, Lname)
        {
            Gradelvl = gradeLevel;
        }

        public override string GetDetails()
        {
            return  $", Grade Level: [{Gradelvl}]";
        }
    }

}

