using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VSDProjekt.Model
{
    public class zariadenie
    {
        public int zariadenieID { get; set; }
        public string Nazov { get; set; }
        public double Spotreba { get; set; }
        public double Dlzka { get; set; }

        public string UserID { get; set; }
    }
}
