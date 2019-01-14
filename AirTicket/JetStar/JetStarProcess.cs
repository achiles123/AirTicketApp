using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AirTicket.JetStar
{
    class JetStarProcess
    {
        public static void process()
        {
            Info data = null;
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.jetstar.com/vi-VN/apiservices/getsitevalues/sitevalues?useCurrentPos=true");
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
                    data = JsonConvert.DeserializeObject<Info>(reader.ReadToEnd());

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

                foreach (AirportList value in data.info)
                {
                    if (value.Airports != null)
                    {
                        foreach (Airport airFrom in value.Airports)
                        {
                            Country country = Helper.CountryMap(airFrom.Key);
                            AirTicket.Airport airPortFrom = db.Airports.Where(x => x.code == airFrom.Key).FirstOrDefault();
                            if (airPortFrom == null)
                            {
                                airPortFrom = new AirTicket.Airport();
                                airPortFrom.code = airFrom.Key;
                                airPortFrom.name = airFrom.Name;
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

                        }
                    }
                }
                foreach (AirportList value in data.info)
                {
                    if (value.Airports != null)
                    {
                        foreach (Airport airFrom in value.Airports)
                        {
                            Country country = Helper.CountryMap(airFrom.Key);
                            AirTicket.Airport airPortFrom = db.Airports.Where(x => x.code == airFrom.Key).FirstOrDefault();
                            From from = db.Froms.Where(x => x.airport_id == airPortFrom.id && x.airline_id == 3).FirstOrDefault();
                            if (from == null)
                            {
                                from = new From();
                                from.airline_id = 3;
                                from.airport_id = airPortFrom.id;
                                db.Froms.Add(from);
                                db.SaveChanges();
                            }
                            if (!string.IsNullOrEmpty(airFrom.Routes.Trim()))
                            {
                                string[] arrTo = airFrom.Routes.Split('|');
                                foreach (string destination in arrTo)
                                {
                                    AirTicket.Airport airPortTo = db.Airports.Where(x => x.code == destination).FirstOrDefault();
                                    To to = db.Toes.Where(x => x.airport_id == airPortTo.id && x.airline_id == 3 && x.from_id == from.id).FirstOrDefault();
                                    if (to == null)
                                    {
                                        to = new To();
                                        to.airline_id = 3;
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
}
