using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDojo.Model
{
    public class Promotion
    {
        public string ProductName { get; set; }
        public int Remise { get; set; }
        public int QuantityTrigger { get; set; }
        public string CountryCode { get; set; }
    }
}
