using AirTicket.JetStar;
using AirTicket.VietJet;
using CefSharp;
using CefSharp.WinForms;
using Fiddler;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace AirTicket
{
    public partial class Form1 : Form
    {
        ChromiumWebBrowser wb;
        public Form1()
        {
            InitializeComponent();
            VNAirProcess.setForm(this);
            Cef.Initialize(new CefSettings());
            wb = new ChromiumWebBrowser("https://fly.vietnamairlines.com/dx/VNDX/#/flight-selection?journeyType=one-way&activeMonth=01-30-2019&pointOfSale=VN&locale=en-US&origin=SGN&destination=HAN&class=Economy&ADT=1&CHD=0&INF=0&date=01-30-2019&execution=e1s1");
            tabPage2.Controls.Add(wb);
            wb.Dock = DockStyle.None;
            wb.Width = 1;
            wb.Height = 1;
            Thread thread = new Thread(new ThreadStart(refreshVNtoken));
            thread.IsBackground = true;
            thread.Start();
        }
        
        void refreshVNtoken()
        {
            while (true)
            {
                Thread.Sleep(1000*60 * 5);
                wb.Reload();
            }
        }

  
        private void button1_Click(object sender, EventArgs e)
        {
            Thread VNAirThread = new Thread(new ThreadStart(VNAirProcess.processMaster));
            VNAirThread.IsBackground = true;
            VNAirThread.Start();
        }

        private void btnVietJet_Click(object sender, EventArgs e)
        {
            Thread vietJetThread = new Thread(new ThreadStart(VietJetProcess.processMaster));
            vietJetThread.IsBackground = true;
            vietJetThread.Start();
        }

        private void btnJetStar_Click(object sender, EventArgs e)
        {
            Thread jetStarThread = new Thread(new ThreadStart(JetStarProcess.processMaster));
            jetStarThread.IsBackground = true;
            jetStarThread.Start();
        }

        private void tsNewCountry_Click(object sender, EventArgs e)
        {
            DialogResult confirm =  MessageBox.Show("Làm mới quốc gia ?","",MessageBoxButtons.OKCancel);
            if(confirm == DialogResult.OK)
            {
                using (AirTicketEntities db = new AirTicketEntities())
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            db.Database.ExecuteSqlCommand("TRUNCATE TABLE [Country]");
                            foreach (KeyValuePair<CountryMap, List<string>> item in Helper.mapList)
                            {
                                Country country = new Country();
                                country.code = item.Key.code;
                                country.name = item.Key.name;
                                db.Countries.Add(country);
                                db.SaveChanges();
                            }
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                        }
                    }
                }
            }
            
            
        }

        private void tsFixCountry_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Sửa lỗi quốc gia ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                using (AirTicketEntities db = new AirTicketEntities())
                {
                    List<Airport> errorItems = db.Airports.Where(x => x.country_id == -1).ToList();
                    if(errorItems != null && errorItems.Count != 0)
                    {
                        foreach(Airport item in errorItems)
                        {
                            Country country = Helper.CountryMap(item.code);
                            if (country == null)
                                continue;
                            item.country = country.name;
                            item.country_code = country.code;
                            item.country_id = country.id;
                            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                        }
                    }
                    
                }
            }
        }

        private void tsCalendar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Tạo lịch ?", "", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                DateTime date = DateTime.Now.Date;
                int year = date.Year;
                DateTime endDate = new DateTime(year, 12, 31);
                using (var db = new AirTicketEntities())
                {
                    while (date <= endDate)
                    {
                        Calendar calendar = db.Calendars.Where(x => x.date == date).FirstOrDefault();
                        if (calendar == null)
                        {
                            calendar = new Calendar();
                            calendar.date = date;
                            db.Calendars.Add(calendar);
                            db.SaveChanges();
                        }
                        date = date.AddDays(1);
                    }
                }
            }
             
        }

        private void btnAirlineProcess_Click(object sender, EventArgs e)
        {
            Thread VNAirThread = new Thread(new ThreadStart(VNAirProcess.processOneWay));
            VNAirThread.IsBackground = true;
            VNAirThread.Start();
        }

        private void installToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CertMaker.rootCertExists())
            {
                if (!CertMaker.createRootCert())
                    return ;

                if (!CertMaker.trustRootCert())
                    return ;
            }
        }

        private void uninstallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CertMaker.rootCertExists())
            {
                if (!CertMaker.removeFiddlerGeneratedCerts(true))
                    return ;
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FiddlerApplication.AfterSessionComplete += FidderProcess.FiddlerApplication_AfterSessionComplete;
            FiddlerApplication.Startup(8888, true, true, true);
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiddlerApplication.AfterSessionComplete -= FidderProcess.FiddlerApplication_AfterSessionComplete;
            if (FiddlerApplication.IsStarted())
                FiddlerApplication.Shutdown();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopToolStripMenuItem.PerformClick();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {

                wb.Reload();
            }
            catch { MessageBox.Show("Hãy thử lại"); }
        }
    }
}
