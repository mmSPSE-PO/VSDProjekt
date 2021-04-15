using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VSDProjekt.Model
{
    public class controller
    {
        public int controllerID { get; set; }

        public string userID { get; set; }
        public string DeviceSerialNumber { get; set; }

        public IEnumerable<connected> Children { get; set; }
    }
}
