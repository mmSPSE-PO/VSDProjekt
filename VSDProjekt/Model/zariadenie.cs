using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VSDProjekt.Model
{
    public class zariadenie
    {
        public int zariadenieID { get; set; }
        [MaxLength(200)]
        public string Nazov { get; set; }
        [Range(0.0,220*20, ErrorMessage = "Pole musí byť väščie ako 0 a menšie ako 4400")]
        public float Spotreba { get; set; }
        [Range(0.0, 24, ErrorMessage = "Pole musí byť väščie ako 0 a menšie ako 24")]
        public float Dlzka { get; set; }

        public string UserID { get; set; }
    }
}
