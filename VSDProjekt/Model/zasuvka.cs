using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VSDProjekt.Model
{
    public class zasuvka
    {
        public int zasuvkaID { get; set; }
        public int? zariadenieID { get; set; }
        public zariadenie Zariadenie { get; set; }

        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        public string UserID { get; set; }
    }
}
