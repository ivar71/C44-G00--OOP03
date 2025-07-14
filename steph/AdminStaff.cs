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

        public AdminStaff(int id, string name, string email, string role) : base(id, name, email)
        {
            Role = role;
        }

        public override string GetDetails()
        {
            return $", Role: [{Role}]";
        }
    }
}
