using AirTicket.JetStar;
using AirTicket.VietJet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTicket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Helper.Check();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread VNAirThread = new Thread(new ThreadStart(VNAirProcess.process));
            VNAirThread.IsBackground = true;
            VNAirThread.Start();
        }

        private void btnVietJet_Click(object sender, EventArgs e)
        {
            Thread vietJetThread = new Thread(new ThreadStart(VietJetProcess.process));
            vietJetThread.IsBackground = true;
            vietJetThread.Start();
        }

        private void btnJetStar_Click(object sender, EventArgs e)
        {
            Thread jetStarThread = new Thread(new ThreadStart(JetStarProcess.process));
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
    }
}
