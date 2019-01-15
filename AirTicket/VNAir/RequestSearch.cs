using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicket.VNAir
{
    class RequestSearch
    {
        public string cabinClass { get; set; }
        public List<ItineraryPart> itineraryParts { get; set; }
        public Passenger passengers { get; set; }
        public string pointOfSale { get; set; }
        public string searchType { get; set; }
    }

    class ItineraryPart
    {
        public ItineraryPartLocation from { get; set; }
        public ItineraryPartLocation to { get; set; }
        public ItineraryPartWhen when { get; set; }
    }
    class ItineraryPartLocation
    {
        public string code { get; set; }
        public bool useNearbyLocations { get; set;}
    }
    class ItineraryPartWhen
    {
        public string date { get; set; }
    }
    class Passenger
    {
        public int ADT { get; set; }
        public int CHD { get; set; }
        public int INF { get; set; }
    }
}
