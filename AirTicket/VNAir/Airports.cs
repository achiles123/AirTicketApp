using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicket.VNAir
{
    class Airports
    {
        public string ClsCode { get; set; }
        public string Code { get; set; }
        public List<Destination> DestinationLocationGroups { get; set; }
        public string DisplayName { get; set; }
        public string HideInFlightInfo { get; set; }
        public string Id { get; set; }
        public bool InvisibleFrom { get; set; }
        public bool IsZone { get; set; }
        public string countryName { get; set; }
    }
}
