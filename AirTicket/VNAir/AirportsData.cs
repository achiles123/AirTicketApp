using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicket.VNAir
{
    class AirportsData
    {
        public List<Airports> Airports  { get; set; }
        public string DisplayName { get; set; }
        public bool HideFromFlightInfo { get; set; }
        public string Id { get; set; }
    }
}
