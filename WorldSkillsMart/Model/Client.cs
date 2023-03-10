using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSkillsMart.Model
{
    public class Client
    {
        public int ID { get; set; }

        public string Role { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public DateTime LastOnline { get; set; }

        public DateTime LastPasswordUpdate { get; set; }

        public bool Confirmed { get; set; }
    }
}
