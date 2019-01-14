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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread VNAirThread = new Thread(new ThreadStart(VNAirProcess.process));
            VNAirThread.IsBackground = true;
            VNAirThread.Start();
        }

        private void btnVietJet_Click(object sender, EventArgs e)
        {
            Thread JetStarThread = new Thread(new ThreadStart(VietJetProcess.process));
            JetStarThread.IsBackground = true;
            JetStarThread.Start();
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
    }
}
