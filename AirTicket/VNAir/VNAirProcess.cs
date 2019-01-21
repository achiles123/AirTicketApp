using AirTicket.VNAir;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AirTicket
{
    class VNAirProcess
    {
        public static void processMaster()
        {
            List<AirportsData> data = null;
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.vietnamairlines.com/Json//GroupLocationFromTo-vi-VN.json");
            request.KeepAlive = false;
            request.Timeout = System.Threading.Timeout.Infinite;
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36";
            CookieContainer cookieContainer = new CookieContainer();
            request.CookieContainer = cookieContainer;
            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception ex)
            {
                return ;
            }
            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                Stream stream = response.GetResponseStream();
                StreamReader reader = null;
                if (response.CharacterSet == null || response.CharacterSet == "")
                {
                    reader = new StreamReader(stream);
                }
                else
                {
                    reader = new StreamReader(stream, Encoding.GetEncoding(response.CharacterSet));
                }
                try
                {
                    data = JsonConvert.DeserializeObject<List<AirportsData>>(reader.ReadToEnd());

                }
                catch (Exception ex)
                {

                }
                reader.Close();
                stream.Close();
            }

            response.Close();
            if (data == null)
                return;
            using (AirTicketEntities db = new AirTicketEntities())
            {
                    try
                    {
                        foreach (AirportsData value in data)
                        {
                            if (value.Airports != null)
                            {
                                foreach (Airports airFrom in value.Airports)
                                {
                                    Country country = Helper.CountryMap(airFrom.Code);
                                    Airport airPortFrom = db.Airports.Where(x => x.code == airFrom.Code).FirstOrDefault();
                                    if (airPortFrom == null)
                                    {
                                        airPortFrom = new Airport();
                                        airPortFrom.code = airFrom.Code;
                                        airPortFrom.name = airFrom.DisplayName;
                                        if (country != null)
                                        {
                                            airPortFrom.country_code = country.code;
                                            airPortFrom.country = country.name;
                                            airPortFrom.country_id = country.id;
                                        }
                                        else
                                        {
                                            airPortFrom.country_code = "-1";
                                            airPortFrom.country = "Khác";
                                            airPortFrom.country_id = -1;
                                        }
                                        db.Airports.Add(airPortFrom);
                                        db.SaveChanges();
                                    }
                                    From from = db.Froms.Where(x => x.airport_id == airPortFrom.id && x.airline_id == 1).FirstOrDefault();
                                    if (from == null)
                                    {
                                        from = new From();
                                        from.airline_id = 1;
                                        from.airport_id = airPortFrom.id;
                                        db.Froms.Add(from);
                                        db.SaveChanges();
                                    }
                                    if (airFrom.DestinationLocationGroups != null)
                                    {
                                        foreach (Destination destination in airFrom.DestinationLocationGroups)
                                        {
                                            if (destination.Airports != null)
                                            {
                                                foreach (Airports airTo in destination.Airports)
                                                {
                                                    Airport airPortTo = db.Airports.Where(x => x.code == airTo.Code).FirstOrDefault();
                                                    if (airPortTo == null)
                                                    {
                                                        Country countryTo = Helper.CountryMap(airTo.Code);
                                                        airPortTo = new Airport();
                                                        airPortTo.name = airTo.DisplayName;
                                                        airPortTo.code = airTo.Code;
                                                        if (countryTo != null)
                                                        {
                                                            airPortTo.country_code = countryTo.code;
                                                            airPortTo.country = countryTo.name;
                                                            airPortTo.country_id = countryTo.id;
                                                        }
                                                        else
                                                        {
                                                            airPortTo.country_code = "-1";
                                                            airPortTo.country = "Khác";
                                                            airPortTo.country_id = -1;
                                                        }
                                                        db.Airports.Add(airPortTo);
                                                        db.SaveChanges();
                                                    }
                                                    To to = db.Toes.Where(x => x.airport_id == airPortTo.id && x.airline_id == 1 && x.from_id == from.id).FirstOrDefault();
                                                    if (to == null)
                                                    {
                                                        to = new To();
                                                        to.airline_id = 1;
                                                        to.from_id = from.id;
                                                        to.airport_id = airPortTo.id;
                                                        db.Toes.Add(to);
                                                        db.SaveChanges();
                                                    }
                                                }
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                    }
                
            }
                
        }

        public static void processOneWay()
        {
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://dc.vietnamairlines.com/v3.6/ssw/products/air/search?jipcc=VNDX");
            request.Method = "POST";
            request.KeepAlive = false;
            request.Timeout = System.Threading.Timeout.Infinite;
            request.Accept = "application/json";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36";
            request.CookieContainer = getCookie();
            request.ContentType = "application/json";
            request.Headers.Add("Authorization", "Bearer T1RLAQIx4m9JvMTrKWRaxoAa34R/ubvAPRAsItOfYHTONrJ3PcWx9uUgAACwyzZCflD5mk0TPPPfn032H4Y/hhwlWHxxA6FGJGIPPhFGVrywnS+obrHEs6OA9gbOTkaebs/MW8KNWq7Jvm4aiDC6M8cJhBegCHP0fKGjzGxrmEsMAkINi2q4rLo2wDWQjTTBIYnruart3SQ0XUpNli8Q9iPhp9T6j68cc3zID2u5E39jGV/OLcIqvLpX7dgA/ZE2LNlV2CIE38ITP3qYy3+LLmWXMRSC7Il+rxoot3U*");
            RequestSearch bodyForm = new RequestSearch();
            bodyForm.cabinClass = "Economy";
            bodyForm.itineraryParts = new List<ItineraryPart>();
            bodyForm.itineraryParts.Add(new ItineraryPart() {
                from = new ItineraryPartLocation() { code = "SGN", useNearbyLocations = false },
                to = new ItineraryPartLocation() { code = "HAN", useNearbyLocations = false },
                when = new ItineraryPartWhen() { date = "2019-01-30"}
            });
            bodyForm.passengers = new VNAir.Passenger() { ADT = 1, CHD = 1, INF = 1 };
            bodyForm.pointOfSale = "VN";
            bodyForm.searchType = "BRANDED";
            byte[] data = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(bodyForm));
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0,data.Length);
            }
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                using (WebResponse responseEx = ex.Response)
                {
                    HttpWebResponse httpResponse = (HttpWebResponse)response;
                    using (Stream dataEx = responseEx.GetResponseStream())
                    using (var reader = new StreamReader(dataEx))
                    {
                        string text = reader.ReadToEnd();
                    }
                }
                return;
            }
            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                Stream stream = response.GetResponseStream();
                StreamReader reader = null;
                if (response.CharacterSet == null || response.CharacterSet == "")
                {
                    reader = new StreamReader(stream);
                }
                else
                {
                    reader = new StreamReader(stream, Encoding.GetEncoding(response.CharacterSet));
                }
                try
                {
                    string result = (reader.ReadToEnd());

                }
                catch (Exception ex)
                {

                }
                reader.Close();
                stream.Close();
            }
            response.Close();
        }

        static CookieContainer getCookie()
        {
            CookieContainer cookie = new CookieContainer();
            cookie.Add(new Cookie()
            {
                Domain = "vietnamairlines.com",
                Name = "isUseCookie",
                Value = "vietnamairlines_usingCookie",
                Expires = DateTime.Now.AddDays(100)
            });

            //ServicePointManager.Expect100Continue = false;
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://dc.vietnamairlines.com/v3.6/ssw/login?execution=e2s1&jipcc=VNDX");
            //request.Method = "OPTIONS";
            //request.KeepAlive = false;
            //request.Timeout = System.Threading.Timeout.Infinite;
            //request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36";
            //request.ContentType = "application/json";
            //request.Headers.Add("Authorization", "Bearer T1RLAQIx4m9JvMTrKWRaxoAa34R/ubvAPRAsItOfYHTONrJ3PcWx9uUgAACwyzZCflD5mk0TPPPfn032H4Y/hhwlWHxxA6FGJGIPPhFGVrywnS+obrHEs6OA9gbOTkaebs/MW8KNWq7Jvm4aiDC6M8cJhBegCHP0fKGjzGxrmEsMAkINi2q4rLo2wDWQjTTBIYnruart3SQ0XUpNli8Q9iPhp9T6j68cc3zID2u5E39jGV/OLcIqvLpX7dgA/ZE2LNlV2CIE38ITP3qYy3+LLmWXMRSC7Il+rxoot3U*");
            //request.Accept = "application/json";
            //HttpWebResponse response = null;
            //try
            //{
            //    response = (HttpWebResponse)request.GetResponse();
            //}
            //catch (Exception ex)
            //{
            //}
            //if (response != null && response.StatusCode == HttpStatusCode.OK)
            //{
            //    cookie.Add(response.Cookies);
            //}
            //response.Close();
            return cookie;
        }
    }
}
