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

        public Student(int id, string name, string email, int gradeLevel) : base(id, name, email)
        {
            Gradelvl = gradeLevel;
        }

        public override string GetDetails()
        {
            return  $", Grade Level: [{Gradelvl}]";
        }
    }

}

