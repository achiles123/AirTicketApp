using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicket
{
    class Helper
    {
        public static Dictionary<CountryMap, List<string> > mapList = new Dictionary<CountryMap, List<string>>()
        {
            {new CountryMap() { code="VIETNAM",name="Việt Nam"}, new List<string>() {
                "VCS","UIH","CAH","VCA","BMV","DAD","DIN","PXU","HPH","HAN","SGN","CXR","VKG","PQC","DLI","VII","TBB","VDH","VCL","HUI","THD","VDO"
            }},
            {new CountryMap() { code="AUSTRALIA",name="Úc"}, new List<string>() {
                "MEL","SYD"
            }},
            {new CountryMap() { code="LAOS",name="Lào"}, new List<string>() {
                "LPQ","VTE"
            }},
            {new CountryMap() { code="CAMPUCHIA",name="Campuchia"}, new List<string>() {
                "PNH","KOS","REP"
            }},
            {new CountryMap() { code="INDONESIA",name="Indonesia"}, new List<string>() {
                "CGK"
            }},
            {new CountryMap() { code="MALAYSIA",name="Malaysia"}, new List<string>() {
                "KUL"
            }},
            {new CountryMap() { code="PHILIPINES",name="Philippines"}, new List<string>() {
                "MNL"
            }},
            {new CountryMap() { code="SINGAPORE",name="Singapore"}, new List<string>() {
                "SIN"
            }},
            {new CountryMap() { code="MYANMAR",name="Myanmar"}, new List<string>() {
                "RGN"
            }},
            {new CountryMap() { code="UAE",name="Các tiểu vương quốc Ả Rập Thống Nhất"}, new List<string>() {
                "AUH"
            }},
            {new CountryMap() { code="SAUDIARABIA",name="Ả Rập Saudi"}, new List<string>() {
                "DMM","RUH"
            }},
            {new CountryMap() { code="BAHRAIN",name="Vương quốc Bahrain"}, new List<string>() {
                "BAH"
            }},
            {new CountryMap() { code="INDIA",name="Ấn Độ"}, new List<string>() {
                "BOM","MAA","DEL"
            }},
            {new CountryMap() { code="THAILAND",name="Thái Lan"}, new List<string>() {
                "BKK","KBV","CNX","CEI","USM","HKT","","","","","",""
            }},
            {new CountryMap() { code="CHINA",name="Trung Quốc"}, new List<string>() {
                "PEK","CTU","CAN","HKG","PVG","WUH","CKG","KMG","XMN","NNG","HGH","NKG","XIY","CZX","TSN","NGB","CGO","HET","CGQ","CSX","FOC","TNA","HAK","HFE",
                "LHW","KHN","DSN","YIW","KWE","SJW","TYN","SHE","WUX","NTG","INC","MFM","DLC","DYG","TNN","TAO","UYN","YIH","YNT","ZYI"
            }},
            {new CountryMap() { code="JAPAN",name="Nhật Bản"}, new List<string>() {
                "SPK","NGO","FUK","KIX","HND","OKA","KMQ","OKJ","TOY","HIJ","MYJ","AXT","SDJ","SYO","NRT","KIJ","CTS","IBR","",""
            }},
            {new CountryMap() { code="KOREA",name="Hàn Quốc"}, new List<string>() {
                "PUS","ICN","TAE","","","",""
            }},
            {new CountryMap() { code="TAIWAN",name="Đài Loan"}, new List<string>() {
                "KHH","TPE","RMQ","","","",""
            }},
            {new CountryMap() { code="NEDERLAND",name="Hà Lan"}, new List<string>() {
                "AMS","","","","",""
            }},
            {new CountryMap() { code="SPAIN",name="Tây Ban Nha"}, new List<string>() {
                "BCN","MAD","","","","",""
            }},
            {new CountryMap() { code="GERMANY",name="Đức"}, new List<string>() {
                "FRA","QYG","","","","",""
            }},
            {new CountryMap() { code="ENGLAND",name="Anh"}, new List<string>() {
                "LHR","","","","","",""
            }},
            {new CountryMap() { code="FRANCE",name="Pháp"}, new List<string>() {
                "MRS","XPJ","NCE","CDG","XWG","XHK","XZV","XSH","QXB","XDB","XZN","QJZ","QXG","ZYN","XYD","ZFJ","ZFQ","XOP","XRF","ETZ","TLS","ZLN","LYS","XIZ","","",""
            }},
            {new CountryMap() { code="RUSIA",name="Nga"}, new List<string>() {
                "DME","","","","","",""
            }},
            {new CountryMap() { code="DENMARK",name="Đan Mạch"}, new List<string>() {
                "CPH","","","","","",""
            }},
            {new CountryMap() { code="CZECH",name="Cộng hoà Séc"}, new List<string>() {
                "PRG","","","","","",""
            }},
            {new CountryMap() { code="ITALY",name="Ý"}, new List<string>() {
                "ROM","","","","","",""
            }},
            {new CountryMap() { code="SWITZERLAND",name="Thuỵ Sỹ"}, new List<string>() {
                "ZRH","GVA","","","","",""
            }},
            {new CountryMap() { code="NORWAY",name="Na Uy"}, new List<string>() {
                "OSL","","","","","",""
            }},
            {new CountryMap() { code="FINLAND",name="Phần Lan"}, new List<string>() {
                "HEL","","","","","",""
            }},
            {new CountryMap() { code="AUSTRIA",name="Áo"}, new List<string>() {
                "VIE","","","","","",""
            }},
            {new CountryMap() { code="USA",name="Hoa Kỳ"}, new List<string>() {
                "ATL","AUS","DFW","HNL","LAX","MIA","MSP","JFK","PDX","SFO","SEA","IAD","BOS","CHI","DEN","PHL","STL","",""
            }},
            {new CountryMap() { code="CANADA",name="Canada"}, new List<string>() {
                "YVR","","","",""
            }},
        };
        public static Country CountryMap(string code)
        {
            Country result = null;
            foreach(KeyValuePair<CountryMap,List<string>> item in mapList)
            {
                string value = item.Value.Where(x => x == code).FirstOrDefault();
                if (value != null)
                    return (new AirTicketEntities()).Countries.Where(x=>x.code==item.Key.code).FirstOrDefault();
            }
            return result;
        }
    }

    class CountryMap
    {
        public string code;
        public string name;
    }
}
