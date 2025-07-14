using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steph
{
    internal class AdminStaff : Person
    {
        public string Role { get; set; }

        public AdminStaff(int age, string Fname, string Lname, string role) : base(age, Fname, Lname)
        {
            Role = role;
        }

        public override string GetDetails()
        {
            return $", Rolيe: [{Role}]";
        }
    }
}
