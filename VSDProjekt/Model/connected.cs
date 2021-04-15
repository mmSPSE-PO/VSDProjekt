using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VSDProjekt.Model
{
    public class connected
    {
        public int connectedID { get; set; }
        public int Spotreba { get; set; }
        public bool Spustene { get; set; }

        public int ParentID { get; set; }
        public controller Parent { get; set; }
    }
}
