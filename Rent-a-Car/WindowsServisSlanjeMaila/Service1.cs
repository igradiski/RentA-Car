using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Mail;

namespace WindowsServisSlanjeMaila
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            this.WriteToFile("Simple Service started {0}");
            this.ScheduleService();
        }

        protected override void OnStop()
        {
            this.WriteToFile("Simple Service stopped {0}");
            this.Schedular.Dispose();
        }

        private Timer Schedular;

        public void ScheduleService()
        {
            try
            {
                Schedular = new Timer(new TimerCallback(SchedularCallback));
                string mode = ConfigurationManager.AppSettings["Mode"].ToUpper();
                this.WriteToFile("Simple Service Mode: " + mode + " {0}");
                
                DateTime scheduledTime = DateTime.MinValue;

                if (mode == "DAILY")
                {
                    scheduledTime = DateTime.Parse(System.Configuration.ConfigurationManager.AppSettings["ScheduledTime"]);
                    if (DateTime.Now > scheduledTime)
                    {
                        scheduledTime = scheduledTime.AddDays(1);
                    }
                }

                if (mode.ToUpper() == "INTERVAL")
                {
                    int intervalMinutes = Convert.ToInt32(ConfigurationManager.AppSettings["IntervalMinutes"]);
                    scheduledTime = DateTime.Now.AddMinutes(intervalMinutes);
                    if (DateTime.Now > scheduledTime)
                    {
                        scheduledTime = scheduledTime.AddMinutes(intervalMinutes);
                    }
                }

                TimeSpan timeSpan = scheduledTime.Subtract(DateTime.Now);
                string schedule = string.Format("{0} day(s) {1} hour(s) {2} minute(s) {3} seconds(s)", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);

                this.WriteToFile("Simple Service scheduled to run after: " + schedule + " {0}");
                int dueTime = Convert.ToInt32(timeSpan.TotalMilliseconds);
                Schedular.Change(dueTime, Timeout.Infinite);
            }
            catch (Exception ex)
            {
                WriteToFile("Simple Service Error on: {0} " + ex.Message + ex.StackTrace);
                using (System.ServiceProcess.ServiceController serviceController = new System.ServiceProcess.ServiceController("SimpleService"))
                {
                    serviceController.Stop();
                }
            }
        }

        private void SchedularCallback(object e)
        {
            try
            {
                List<Korisnik> listaKorisnika = new List<Korisnik>();
                DateTime datum = DateTime.Now.AddDays(1);
                TimeSpan vrijeme = new TimeSpan(0, 0, 0);
                datum = datum.Date + vrijeme;
                List<Rezervacija> listaRezervacija = null;
                using(Entities db=new Entities())
                {
                    listaRezervacija = (from r in db.Rezervacija select r).ToList();
                }
                using (Entities db = new Entities()) {
                    foreach (Rezervacija rezervacija in listaRezervacija)
                    {
                        if (rezervacija.DatumPocetka.CompareTo(datum) == 0)
                        {
                            listaKorisnika.Add((from k in db.Korisnik where k.KorisnikID == rezervacija.KorisnikID select k).First());
                            Iznajmljivanje iznajmljivanje = new Iznajmljivanje();
                            iznajmljivanje.KlijentID = rezervacija.KorisnikID;
                            iznajmljivanje.VoziloID = rezervacija.VoziloID;
                            iznajmljivanje.DatumPocetka = rezervacija.DatumPocetka;
                            iznajmljivanje.DatumKraja = rezervacija.DatumKraja;
                            iznajmljivanje.BrojDana = rezervacija.BrojDana;
                            iznajmljivanje.DjelatnikID = null;
                            iznajmljivanje.JedinicnaCijena = rezervacija.JedinicnaCijena;
                            iznajmljivanje.Naplaceno = false;
                            Vozilo vozilo = null;
                            TipMotora tipMotora = null;
                            vozilo = (from v in db.Vozilo where v.VoziloID == rezervacija.VoziloID select v).FirstOrDefault();
                            tipMotora = (from tm in db.TipMotora where tm.TipMotoraID == vozilo.TipMotoraID select tm).FirstOrDefault();
                            iznajmljivanje.Naziv = vozilo.Naziv + " " + tipMotora.Naziv;
                            iznajmljivanje.Opis = "Iznajmljivanje vozila " + iznajmljivanje.Naziv + " na " + iznajmljivanje.BrojDana.ToString() + " dana s cijenom od " + iznajmljivanje.JedinicnaCijena.ToString() + "kn po danu.";
                            iznajmljivanje.UkupnaCijena = iznajmljivanje.BrojDana * iznajmljivanje.JedinicnaCijena;
                            iznajmljivanje.RacunID = null;
                            db.Iznajmljivanje.Add(iznajmljivanje);
                            db.SaveChanges();
                            db.Rezervacija.Remove(rezervacija);
                            db.SaveChanges();
                        }
                    }
                }
                for(int i=0; i < listaKorisnika.Count-1; i++)
                {
                    for(int j=i+1; j<listaKorisnika.Count; j++)
                    {
                        if (listaKorisnika[i].KorisnikID == listaKorisnika[j].KorisnikID)
                        {
                            listaKorisnika.Remove(listaKorisnika[j]);
                        }
                    }
                }
                foreach (Korisnik row in listaKorisnika)
                {

                    string name = row.Ime.ToString();
                    string surname = row.Prezime.ToString();
                    string email = row.Mail.ToString();
                    WriteToFile("Trying to send email to: " + name + " " + email);

                    using (MailMessage mm = new MailMessage("sender@gmail.com", email))
                    {
                        mm.Subject = "Podsjetnik na rezervaciju vozila";
                        mm.Body = string.Format("<b>Poštovani </b>{0} {1}<br /><br />Podsjećamo Vas da ste kod nas rezervirali vozilo/vozila na datum {2}.<br /><br />S poštovanjem,<br />Vaš Željni znanja Rent a car<br />", name, surname, DateTime.Today.AddDays(1).ToString("dd.MM.yyyy"));

                        mm.IsBodyHtml = true;
                        SmtpClient smtp = new SmtpClient();
                        smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        System.Net.NetworkCredential credentials = new System.Net.NetworkCredential();
                        credentials.UserName = "vin.cerovecki@gmail.com";
                        credentials.Password = "Babt4AvQ";
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = credentials;
                        smtp.Port = 587;
                        smtp.Send(mm);
                        WriteToFile("Email sent successfully to: " + name + " " + email);
                    }
                }

                listaKorisnika = null;
                using(Entities db=new Entities())
                {
                    listaKorisnika = ((from k in db.Korisnik join i in db.Iznajmljivanje on k.KorisnikID equals i.KlijentID where i.DatumKraja==datum select k).ToList());
                }

                foreach (Korisnik korisnik in listaKorisnika)
                {
                    string name = korisnik.Ime.ToString();
                    string surname = korisnik.Prezime.ToString();
                    string email = korisnik.Mail.ToString();
                    WriteToFile("Trying to send email to: " + name + " " + email);

                    using (MailMessage mm = new MailMessage("sender@gmail.com", email))
                    {
                        mm.Subject = "Podsjetnik na rezervaciju vozila";
                        mm.Body = string.Format("<b>Poštovani </b>{0} {1}<br /><br />Podsjećamo Vas da je termin vraćanja vašeg vozila sutra./vozila na datum {2}.<br /><br />S poštovanjem,<br />Vaš Željni znanja Rent a car<br />", name, surname, DateTime.Today.AddDays(1).ToString("dd.MM.yyyy"));

                        mm.IsBodyHtml = true;
                        SmtpClient smtp = new SmtpClient();
                        smtp.Host = "smtp.gmail.com";
                        smtp.EnableSsl = true;
                        System.Net.NetworkCredential credentials = new System.Net.NetworkCredential();
                        credentials.UserName = "vin.cerovecki@gmail.com";
                        credentials.Password = "Babt4AvQ";
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = credentials;
                        smtp.Port = 587;
                        smtp.Send(mm);
                        WriteToFile("Email sent successfully to: " + name + " " + email);
                    }
                }

                this.ScheduleService();
            }
            catch (Exception ex)
            {
                WriteToFile("Simple Service Error on: {0} " + ex.Message + ex.StackTrace);
                using (System.ServiceProcess.ServiceController serviceController = new System.ServiceProcess.ServiceController("SimpleService"))
                {
                    serviceController.Stop();
                }
            }
        }

        private void WriteToFile(string text)
        {
            string path = "C:\\ServiceLog.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(string.Format(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")), text);
                writer.Close();
            }
        }
    }
}
