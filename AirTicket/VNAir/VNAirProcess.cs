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
        public static void process()
        {
            List<AirportsData> data = null;
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.vietnamairlines.com/Json//GroupLocationFromTo-en.json");
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
            AirTicketEntities db = new AirTicketEntities();
            foreach (AirportsData value in data)
            {
                Country country = db.Countries.Where(x => x.code == value.DisplayName).FirstOrDefault();
                if (country == null)
                {
                    country = new Country();
                    country.name = value.DisplayName;
                    country.code = value.DisplayName;
                    db.Countries.Add(country);
                    db.SaveChanges();
                }
            }
            foreach (AirportsData value in data)
            {
                Country country = db.Countries.Where(x => x.code == value.DisplayName).FirstOrDefault();
                if(value.Airports != null)
                {
                    foreach (Airports airFrom in value.Airports)
                    {
                        From from = db.Froms.Where(x => x.code == airFrom.Code && x.country_code==airFrom.countryName).FirstOrDefault();
                        if(from == null)
                        {
                            from = new From();
                            from.code = airFrom.Code;
                            from.name = airFrom.DisplayName;
                            from.country_code = country.code;
                            from.country = country.code;
                            from.country_id = country.id;
                            db.Froms.Add(from);
                            db.SaveChanges();
                        }
                        if(airFrom.DestinationLocationGroups != null)
                        {
                            foreach (Destination destination in airFrom.DestinationLocationGroups)
                            {
                                if(destination.Airports != null)
                                {
                                    foreach(Airports airTo in destination.Airports)
                                    {
                                        To to = db.Toes.Where(x => x.code == airTo.Code && x.country_code == airTo.countryName && x.From.country_code == airFrom.countryName).FirstOrDefault();
                                        if (to == null)
                                        {
                                            Country countryTo = db.Countries.Where(x => x.code == destination.DisplayName).FirstOrDefault();
                                            to = new To();
                                            to.from_id = from.id;
                                            to.name = airTo.DisplayName;
                                            to.code = airTo.Code;
                                            to.country = destination.DisplayName;
                                            to.country_code = destination.DisplayName;
                                            to.country_id = countryTo.id;
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
    }
}
