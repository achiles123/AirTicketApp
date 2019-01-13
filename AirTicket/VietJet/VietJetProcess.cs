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
        public static void process()
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
            AirTicketEntities db = new AirTicketEntities();
            foreach (Pair value in data.Pair)
            {
                
                
            }
        }
    }
}
