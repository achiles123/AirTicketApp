using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AirTicket.VietJet
{
    class VietJetProcess
    {
        public static void processMaster()
        {
            VietJetAirport data = null;
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.vietjetair.com/AirportList.aspx?lang=vi-VN");
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
                    data = JsonConvert.DeserializeObject<VietJetAirport>(reader.ReadToEnd());

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
                foreach (Pair pair in data.Pair)
                {
                    AirTicket.Airport airPortFrom = db.Airports.Where(x => x.code == pair.DepartureAirport.Code).FirstOrDefault();
                    if (airPortFrom == null)
                    {
                        Country country = Helper.CountryMap(pair.DepartureAirport.Code);
                        airPortFrom = new AirTicket.Airport();
                        airPortFrom.code = pair.DepartureAirport.Code;
                        airPortFrom.name = pair.DepartureAirport.Name;
                        if(country != null)
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
                    From from = db.Froms.Where(x => x.airport_id == airPortFrom.id && x.airline_id == 2).FirstOrDefault();
                    if (from == null)
                    {
                        from = new From();
                        from.airline_id = 2;
                        from.airport_id = airPortFrom.id;
                        db.Froms.Add(from);
                        db.SaveChanges();
                    }
                    if (pair.ArrivalAirports.AirportList != null)
                    {
                        foreach (Airport item in pair.ArrivalAirports.AirportList)
                        {
                            foreach (AirportList airTo in item.List)
                            {
                                AirTicket.Airport airPortTo = db.Airports.Where(x => x.code == airTo.Code).FirstOrDefault();
                                if (airPortTo == null)
                                {
                                    Country country = Helper.CountryMap(airTo.Code);
                                    airPortTo = new AirTicket.Airport();
                                    airPortTo.name = airTo.Name;
                                    airPortTo.code = airTo.Code;
                                    if (country != null)
                                    {
                                        airPortTo.country_code = country.code;
                                        airPortTo.country = country.name;
                                        airPortTo.country_id = country.id;
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
                                To to = db.Toes.Where(x => x.airport_id == airPortTo.id && x.airline_id == 2 && x.from_id == from.id).FirstOrDefault();
                                if (to == null)
                                {
                                    to = new To();
                                    to.airline_id = 2;
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
