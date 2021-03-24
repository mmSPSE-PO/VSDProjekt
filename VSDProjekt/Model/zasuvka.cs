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
        /*
        public int h0 { get; set; }
        public int h1 { get; set; }
        public int h2 { get; set; }
        public int h3 { get; set; }
        public int h4 { get; set; }
        public int h5 { get; set; }
        public int h6 { get; set; }
        public int h7 { get; set; }
        public int h8 { get; set; }
        public int h9 { get; set; }
        public int h10 { get; set; }
        public int h11 { get; set; }
        public int h12 { get; set; }
        public int h13 { get; set; }
        public int h14 { get; set; }
        public int h15 { get; set; }
        public int h16 { get; set; }
        public int h17 { get; set; }
        public int h18 { get; set; }
        public int h19 { get; set; }
        public int h20 { get; set; }
        public int h21 { get; set; }
        public int h22 { get; set; }
        public int h23 { get; set; }
        */
    }
}