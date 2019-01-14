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
                "MEL","SYD","ADL","BNK","BNE","CNS","CBR","JLM","DRW","OOL","HTI","HIS","HBA","HBA","MKY","VIZ","AVV","NTL","PER","MCY","TSV","AYQ","PPP","LST"
            }},
            {new CountryMap() { code="LAOS",name="Lào"}, new List<string>() {
                "LPQ","VTE","AOU","PKZ"
            }},
            {new CountryMap() { code="CAMBODIA",name="Campuchia"}, new List<string>() {
                "PNH","KOS","REP"
            }},
            {new CountryMap() { code="INDONESIA",name="Indonesia"}, new List<string>() {
                "UPG","MDC","LOP","KNO","PDG","PLM","PKU","SRI","SRG","SUB","SOC","JOG","CGK","HLP","DPS","BDO","BPN","AMQ","PKY","DJJ","BDJ","KOE","PLW","KDI"
            }},
            {new CountryMap() { code="MALAYSIA",name="Malaysia"}, new List<string>() {
                "IPH","JHB","KBR","BKI","KUL","KCH","LGK","PEN","SZB"
            }},
            {new CountryMap() { code="PHILIPINES",name="Philippines"}, new List<string>() {
                "BCD","CEB","CRK","DVO","GES","ILO","KLO","LAO","MNL","TAG","PPS","SFS","ZAM"
            }},
            {new CountryMap() { code="SINGAPORE",name="Singapore"}, new List<string>() {
                "SIN"
            }},
            {new CountryMap() { code="MYANMAR",name="Myanmar"}, new List<string>() {
                "RGN","MDL","NYT"
            }},
            {new CountryMap() { code="UAE",name="Các tiểu vương quốc Ả Rập Thống Nhất"}, new List<string>() {
                "AUH","AAN","DWC","DXB","RKT","SHJ"
            }},
            {new CountryMap() { code="SAUDIARABIA",name="Ả Rập Saudi"}, new List<string>() {
                "DMM","RUH","JED","MED"
            }},
            {new CountryMap() { code="BAHRAIN",name="Vương quốc Bahrain"}, new List<string>() {
                "BAH"
            }},
            {new CountryMap() { code="INDIA",name="Ấn Độ"}, new List<string>() {
                "IXZ","AMD","ATQ","BLR","BHO","BBI","IXC","MAA","COK","CJB","DEL","DHR","GOI","MGI","GAY","GAU","HYD","IMF","IDR","JAI","CNN","CCU","CCJ","SIA",
                "LKO","IXM","IXE","BOM","NAG","NMA","KPR","IXZ","PAT","PNQ",@"CRA\NPQ","RPR","IXR","IXB","SXR","TRZ","TIR","TRV","VNS","VGA","VTZ","VSA",
            }},
            {new CountryMap() { code="THAILAND",name="Thái Lan"}, new List<string>() {
                "BKK","DMK","CNX","CEI","HDY","HKT","USM","KBV","UTH","URT","UTP"
            }},
            {new CountryMap() { code="CHINA",name="Trung Quốc"}, new List<string>() {
                "HKG","HET","DSN","YIW","MFM","TNN","UYN","YIH","ZYI","BHY","PEK","NAY","CGQ","CSX","CZX","CTU","CKG","DDG","DLC","DNH","FOC","CAN","KWL","KWE",
                "HAK","HGH","HRB","HFE","HUZ","SWA","TNA","KMG","LHW","LXA","LZH","LYA","MIG","MDG","KHN","NKG","NNG","NTG","NGB","TAO","JJN","SYX","SHA","PVG",
                "SHE","SZX","SJW","WUX","TYN","TSN","THQ","URC","WEH","WNZ","WUH","XMN","XIY","XFN","XNN","XIC","XUZ","YNZ","YNJ","YNT","INC","DYG","YZY","CGO",
                "HSN","ZUH"
            }},
            {new CountryMap() { code="JAPAN",name="Nhật Bản"}, new List<string>() {
                "SPK","OKA","TOY","MYJ","SYO","IBR","KCZ","KMJ","KMI","TAK","SHI","AXT","AOJ","FUK","HKD","KOJ","KMQ","HIJ","KKJ","NGS","NGO","KIJ","OIT","OKJ",
                "KIX","CTS","SDJ","FSZ","HND","NRT"
            }},
            {new CountryMap() { code="KOREA",name="Hàn Quốc"}, new List<string>() {
                "PUS","TAE","CJU","GMP","ICN","CJJ","MWX","YNY"
            }},
            {new CountryMap() { code="TAIWAN",name="Đài Loan"}, new List<string>() {
                "KHH","TPE","RMQ","TSA"
            }},
            {new CountryMap() { code="NEDERLAND",name="Hà Lan"}, new List<string>() {
                "AMS","EIN","GRQ","MST","RTM",""
            }},
            {new CountryMap() { code="SPAIN",name="Tây Ban Nha"}, new List<string>() {
                "LCG","ALC","LEI","OVD","BCN","FUE","GRO","LPA","GRX","HSK","IBZ","XRY","SPC","ACE","ILD","MAD","AGP","MAH","MJV","PMI","REU","SDR","SCQ","SVQ",
                "TFN","TFS","VLC","VLL","ZAZ"
            }},
            {new CountryMap() { code="GERMANY",name="Đức"}, new List<string>() {
                "QYG","FKB","TXL","SXF","BER","BRE","CGN","DTM","DUS","FRA","HHN","MLH/BSL/EAP","FDH","HAM","HAJ","LEJ","LBC","FMM","MUC","NUE","STR","NRN"
            }},
            {new CountryMap() { code="ENGLAND",name="Anh"}, new List<string>() {
                "BHX","BOH","BRS","CWL","DSA","MME","EMA","EXT","LBA","LPL","LCY","LGW","LHR","LTN","SEN","STN","MAN","NCL","NQY","NWI","SOU",
            }},
            {new CountryMap() { code="FRANCE",name="Pháp"}, new List<string>() {
                "AJA","BIA","BVA","EGC","BZR","BIQ","BOD","BES","CCF","XCR","CMF","DNR","FSC","GNB","LRH","LIL","LIG","LYS","MRS","BSL","NTE","NCE","FNI","CDG",
                "ORY","PUF","PGF","PIS","RDZ","EBU","SXB","TLN","TLS","TUF","XDB","XZN","QJZ","QXG","ZYN","XYD","ZFJ","ZFQ","XOP","XRF","ETZ","XIZ","ZLN","XPJ",
                "XWG","XHK","XZV","XSH","QXB"
            }},
            {new CountryMap() { code="RUSIA",name="Nga"}, new List<string>() {
                "ABA","DYR","AAQ","ARH","ASF","BAX","EGO","BQS","BTK","BZK","CSY","CEK","CEE","HTA","ESL","IKT","GRV","KGD","KZN","KHV","KXK","KRR","KJA","URS",
                "GDX","MQF","MCX","MRV","DME","SVO","VKO","MMK","NAL","NJC","NBC","GOJ","NOZ","OVB","OMS","REN","OSW","PEE","PES","PVS","PKC","PKV","ROV","LED",
                "KUF","RTW","AER","STW","SGC","SCW","TOF","TJM","UUD","ULY","UFA","VVO","OGZ","VOG","VOZ","YKS","IAR","SVX","UUS",
            }},
            {new CountryMap() { code="DENMARK",name="Đan Mạch"}, new List<string>() {
                "CPH","BLL","AAR","AAL"
            }},
            {new CountryMap() { code="CZECH",name="Cộng hoà Séc"}, new List<string>() {
                "PRG","PED","OSR","KLV","BRQ"
            }},
            {new CountryMap() { code="ITALY",name="Ý"}, new List<string>() {
                "ROM","","","","","",""
            }},
            {new CountryMap() { code="SWITZERLAND",name="Thuỵ Sỹ"}, new List<string>() {
                "ZRH","GVA","ACH","BRN","BSL","",""
            }},
            {new CountryMap() { code="NORWAY",name="Na Uy"}, new List<string>() {
                "AES","BGO","BOO","HAU","KRS","KSU","OSL","RYG","TRF","SVG","TOS","TRD",
            }},
            {new CountryMap() { code="FINLAND",name="Phần Lan"}, new List<string>() {
                "MHQ","HEL","KTT","KUO","KAO","LPP","OUL","RVN","TMP","TKU","VAA",
            }},
            {new CountryMap() { code="AUSTRIA",name="Áo"}, new List<string>() {
                "GRZ","KLU","INN","LNZ","SZG","VIE",
            }},
            {new CountryMap() { code="USA",name="Hoa Kỳ"}, new List<string>() {
                "CHI","CAK","AKC","ALB","ABQ","ANC","ATW","ATL","ACY","AUS","BWI","BGR","BHM","BOS","BUF","CLT","CHS","MDW","RFD","ORD","CVG","CLE","CMH","LCK",
                "DFW","DAY","DEN","DSM","DTW","FAI","FLL","RSW","FAT","BDL","GRB","ITO","HNL","IAH","HOU","HSV","IND","JAX","JNU","MCI","KTN","EYW","KOA","LAL",
                "LAN","LAS","LAX","SDF","MLB","MEM","MIA","MKE","MSP","MYR","BNA","MSY","JFK","LGA","EWR","SWF","OAK","OMA","ONT","SNA","MCO","SFB","PSP","ECP",
                "PHL","PHX","AZA","PIT","PWM","PDX","PVD","RDU","RNO","ROC","RST","SMF","SLC","SAT","SBD","SAN","SFO","SJC","SJU","SRQ","LKE","BFI","SEA","PAE",
                "GEG","STL","PIE","SYR","TLH","TPA","DCA","IAD","PBI",
            }},
            {new CountryMap() { code="CANADA",name="Canada"}, new List<string>() {
                "YYC","YEG","YQX","YHZ","YHM","YFB","YLW","YQM","YMX","YUL","YOW","YQB","YQR","YXE","YYT","YQT","YTZ","YYZ","YVR","YYJ","YXY","YWG",
            }},
            {new CountryMap() { code="NEWZEALAND",name="New Zealand"}, new List<string>() {
                "NAN","RAR","AKL","CHC","DUD","NPE","NSN","NPL","PMR","ZQN","WLG",""
            }},
        };
        public static Country CountryMap(string code)
        {
            code = code.ToLower();
            Country result = null;
            foreach(KeyValuePair<CountryMap,List<string>> item in mapList)
            {
                string value = item.Value.Where(x => x.ToLower() == code).FirstOrDefault();
                if (value != null)
                    return (new AirTicketEntities()).Countries.Where(x=>x.code==item.Key.code).FirstOrDefault();
            }
            return result;
        }

        public static void Check()
        {
            List<string> temp = new List<string>()
            {
"CAK",
"AKC",
"ALB",
"ABQ",
"ANC",
"ATW",
"ATL",
"ACY",
"AUS",
"BWI",
"BGR",
"BHM",
"BOS",
"BUF",
"CLT",
"CHS",
"MDW",
"RFD",
"ORD",
"CVG",
"CLE",
"CMH",
"LCK",
"DFW",
"DAY",
"DEN",
"DSM",
"DTW",
"FAI",
"FLL",
"RSW",
"FAT",
"BDL",
"GRB",
"ITO",
"HNL",
"IAH",
"HOU",
"HSV",
"IND",
"JAX",
"JNU",
"MCI",
"KTN",
"EYW",
"KOA",
"LAL",
"LAN",
"LAS",
"LAX",
"SDF",
"MLB",
"MEM",
"MIA",
"MKE",
"MSP",
"MYR",
"BNA",
"MSY",
"JFK",
"LGA",
"EWR",
"SWF",
"OAK",
"OMA",
"ONT",
"SNA",
"MCO",
"SFB",
"PSP",
"ECP",
"PHL",
"PHX",
"AZA",
"PIT",
"PWM",
"PDX",
"PVD",
"RDU",
"RNO",
"ROC",
"RST",
"SMF",
"SLC",
"SAT",
"SBD",
"SAN",
"SFO",
"SJC",
"SJU",
"SRQ",
"LKE",
"BFI",
"SEA",
"PAE",
"GEG",
"STL",
"PIE",
"SYR",
"TLH",
"TPA",
"DCA",
"IAD",
"PBI",

            };
            foreach(KeyValuePair<CountryMap, List<string>> item in mapList)
            {
                if(item.Key.code == "USA")
                {
                    foreach(string name in item.Value)
                    {
                        if (name == "")
                            continue;
                        if (temp.FindIndex(x=>x==name) < 0)
                        {
                            int a = 1;
                        }
                    }
                }
            }
        }
    }

    class CountryMap
    {
        public string code;
        public string name;
    }
}
