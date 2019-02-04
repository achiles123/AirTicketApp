using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicket.VNAir
{
    class ResponseVNAir
    {
        public BrandedResult brandedResults { get; set; }
    }

    public class BrandedResult
    {
        public ReponseItineraryPart [][]itineraryPartBrands { get; set; }
    }

    public class ReponseItineraryPart
    {
        public string arrival { get; set; }
        public List<ReponseBrandOffer> brandOffers { get; set; }
        public string departure { get; set; }
        public int duration { get; set; }
    }

    public class ReponseBrandOffer
    {
        public string brandId { get; set; }
        public string cabinClass { get; set; }
        public ReponseAlternative fare { get; set; }
        public ResponseOfferInformation offerInformation { get; set; }
        public ResponseSeatsRemaining seatsRemaining { get; set; }
        public bool soldout { get; set; }
        public ReponseAlternative taxes { get; set; }
        public ReponseAlternative total { get; set; }
        public ReponseAlternative totalMandatoryObFees { get; set; }
    }

    public class ReponseAlternative
    {
        public ReponseAlternativeDetail[][] alternatives { get; set; }
    }

    public class ReponseAlternativeDetail
    {
        public decimal amount { get; set; }
        public string currency { get; set; }
    }

    public class ResponseOfferInformation
    {
        public bool discounted { get; set; }
        public bool negotiated { get; set; }
        public string negotiatedType { get; set; }
    }
    public class ResponseSeatsRemaining
    {
        public int count { get; set; }
        public bool lowAvailability { get; set; }
    }
}
