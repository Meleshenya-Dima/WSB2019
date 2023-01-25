using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSkillsMart.Model
{
    public class Accessory
    {
        public int Accessory_ID { get; set; }

        public string AccName { get; set; }

        public string DescriptionOfAccessory { get; set; }

        public float Price { get; set; }

        public float VAT { get; set; }

        public int Inventory { get; set; }

        public int OrderLevel { get; set; }

        public int OrderBatch { get; set; }

        public int Partner_ID { get; set; }
    }
}
