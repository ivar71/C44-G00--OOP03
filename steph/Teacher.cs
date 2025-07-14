using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steph
{
    internal class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(int id, string name, string email, string subject) : base(id, name, email)
        {
            Subject = subject;
        }

        public override string GetDetails()
        {
            return $", Subject: [{Subject}]";
        }
    }
}
