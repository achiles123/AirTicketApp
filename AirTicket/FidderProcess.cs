using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiddler;

namespace AirTicket
{
    class FidderProcess
    {
        private static UrlCaptureConfiguration CaptureConfiguration { get; set; }
        public static void FiddlerApplication_AfterSessionComplete(Session sess)
        {
            // Ignore HTTPS connect requests
            if (sess.RequestMethod == "CONNECT")
                return;

            //if (CaptureConfiguration.ProcessId > 0)
            //{
            //    if (sess.LocalProcessID != 0 && sess.LocalProcessID != CaptureConfiguration.ProcessId)
            //        return;
            //}

            //if (!string.IsNullOrEmpty(CaptureConfiguration.CaptureDomain))
            //{
            //    if (sess.hostname.ToLower() != CaptureConfiguration.CaptureDomain.Trim().ToLower())
            //        return;
            //}

            //if (CaptureConfiguration.IgnoreResources)
            //{
            //    string url = sess.fullUrl.ToLower();

            //    var extensions = CaptureConfiguration.ExtensionFilterExclusions;
            //    foreach (var ext in extensions)
            //    {
            //        if (url.Contains(ext))
            //            return;
            //    }

            //    var filters = CaptureConfiguration.UrlFilterExclusions;
            //    foreach (var urlFilter in filters)
            //    {
            //        if (url.Contains(urlFilter))
            //            return;
            //    }
            //}

            if (sess == null || sess.oRequest == null || sess.oRequest.headers == null)
                return;
            string headers = sess.oRequest.headers.ToString();
            string firstLine = sess.RequestMethod + " " + sess.fullUrl + " " + sess.oRequest.headers.HTTPVersion;
            int at = headers.IndexOf("\r\n");
            string VNAirInfoUrl = "dc.vietnamairlines.com/v3.6/ssw/products/air/search?execution=e1s1&jipcc=VNDX";
            if (sess.url.ToLower() == VNAirInfoUrl.ToLower())
            {
                int startIndex = headers.IndexOf("Authorization: ");
                if(startIndex != -1)
                {
                    startIndex += 15;
                    int endIndex = headers.IndexOf("Conversation-ID", startIndex);
                    if(endIndex != -1)
                    {
                        string authorization = headers.Substring(startIndex,endIndex-startIndex);
                        Properties.Settings.Default.vnAirToken = authorization;
                        Properties.Settings.Default.Save();
                    }
                }
                    
            }
            
            var reqBody = Encoding.UTF8.GetString(sess.RequestBody);

            // if you wanted to capture the response
            //string respHeaders = session.oResponse.headers.ToString();
            //var respBody = Encoding.UTF8.GetString(session.ResponseBody);

            // replace the HTTP line to inject full URL
            if (at < 0)
                return;
            headers = firstLine + "\r\n" + headers.Substring(at + 1);
        }

        static void SetConfig(Session sess)
        {

        }
    }
}
