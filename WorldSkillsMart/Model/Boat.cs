using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSkillsMart.Model
{
    public class Boat
    {
        public int Boat_ID { get; set; }

        public string Model { get; set; }

        public string BoatType { get; set; }

        public int NumberOfRowers { get; set; }

        public bool Mast { get; set; }

        public string Color { get; set; }

        public string Wood { get; set; }

        public float BasePrice { get; set; }

        public int VAT { get; set; }
    }
}
