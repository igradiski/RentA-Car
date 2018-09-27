using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Rent_a_Car
{
    public partial class Vozilo
    {
        /*
         * Vraca vozila koja nisu rezervirana unutar definiranih datuma pocetka i kraja.
         */
        /// <summary>
        /// Vraca vozila koja nisu rezervirana unutar definiranih datuma pocetka i kraja.
        /// </summary>
        /// <param name="datumVrijemePocetka"></param>
        /// <param name="datumVrijemeKraja"></param>
        /// <returns>
        /// 
        /// </returns>
        public static BindingList<Vozilo> PrikaziVozila(DateTime datumVrijemePocetka, DateTime datumVrijemeKraja)
        {
            BindingList<Vozilo> listaVozila = null;
            using (var db = new RentACarEntities())
            {
                listaVozila = new BindingList<Vozilo>((from v in db.Vozilo where (!db.Rezervacija.Any(r => (r.VoziloID == v.VoziloID && ((datumVrijemePocetka >= r.DatumPocetka && datumVrijemePocetka <= r.DatumKraja) || (datumVrijemeKraja >= r.DatumPocetka && datumVrijemeKraja <= r.DatumKraja)))) && (!db.Iznajmljivanje.Any(r => (r.VoziloID == v.VoziloID && ((datumVrijemePocetka >= r.DatumPocetka && datumVrijemePocetka <= r.DatumKraja) || (datumVrijemeKraja >= r.DatumPocetka && datumVrijemeKraja <= r.DatumKraja)))))) select v).ToList());
            }
            return listaVozila;
        }
        /// <summary>
        /// Metoda koja dohvaća sva vozila iz baze
        /// </summary>
        /// <returns></returns>
        public static BindingList<Vozilo> DohvatiVozila()
        {
            BindingList<Vozilo> lista = null;
            using (RentACarEntities db = new RentACarEntities())
            {
                lista = new BindingList<Vozilo>(db.Vozilo.ToList());
            }
            return lista;
        }
        /// <summary>
        /// Metoda provjerava dali postoji vec vozilo u bazi sa određenim registracijskim oznakama
        /// </summary>
        /// <param name="registracija">Registracije oznake koje treba provjeriti</param>
        /// <returns></returns>
        public static bool ProvjeriDostupnostRegistraciskihOznaka(string registracija)
        {
            Vozilo vozilo = null;
            using (RentACarEntities db = new RentACarEntities())
            {
                vozilo = (from v in db.Vozilo where v.VoziloID == registracija select v).FirstOrDefault();
            }
            if (vozilo == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Metoda koja dodaje vozilo u bazu
        /// </summary>
        /// <param name="vozilo">Vozilo koje treba dodati</param>
        public static void DodajVozilo(Vozilo vozilo)
        {
            using (RentACarEntities db = new RentACarEntities())
            {
                db.Vozilo.Add(vozilo);
                db.SaveChanges();
            }
        }

        /*
         * Dohvaća vozilo po ID-u vozila.
         */
         
        public static Vozilo DohvatiVoziloPoRegistraciji(string registracija)
        {
            Vozilo vozilo = null;
            using(RentACarEntities db=new RentACarEntities())
            {
                vozilo = (from v in db.Vozilo where v.VoziloID == registracija select v).FirstOrDefault();
            }
            return vozilo;
        }
        /// <summary>
        /// Motoda dohvaća vozila iz baze filtrirane po nazivu
        /// </summary>
        /// <param name="naziv"> Vozila se filtriraju po nazivu</param>
        /// <returns></returns>
        public static BindingList<Vozilo> DohvatiVozilaPoNazivu(string naziv)
        {
            BindingList<Vozilo> lista = null;
            using (RentACarEntities db = new RentACarEntities())
            {
                lista = new BindingList<Vozilo>((from v in db.Vozilo where v.Naziv.Contains(naziv) select v).ToList());
            }
            return lista;
        }
        public static BindingList<Vozilo> DohvatiVozilaPoRegistraciji(string registracija)
        {
            BindingList<Vozilo> lista = null;
            using (RentACarEntities db = new RentACarEntities())
            {
                lista = new BindingList<Vozilo>((from v in db.Vozilo where v.VoziloID.Contains(registracija) select v).ToList());
            }
            return lista;
        }

        /// <summary>
        /// Motoda dohvaća vozila iz baze filtrirane po registracijskim oznakama
        /// </summary>
        /// <param name="registracija"> Registracijska oznaka po kojoj dohvaćamo</param>
        /// <returns></returns>
        public static BindingList<Vozilo> DohvatiVozilaPoRegistracijskimOznakama(string registracija)
        {
            BindingList<Vozilo> lista = null;
            using (RentACarEntities db = new RentACarEntities())
            {
                lista = new BindingList<Vozilo>((from v in db.Vozilo where v.VoziloID.Contains(registracija) select v).ToList());
            }
            return lista;
        }
        public static List<Vozilo> SvaVozila()
        {

            
            using(RentACarEntities db = new RentACarEntities())
            {
                List<Vozilo> lista = new List<Vozilo>(db.Vozilo.ToList());
                return lista;
            }
            
        }

        public static Vozilo DohvatiVoziloPoIznajmljivanju(Iznajmljivanje iznajmljivanje)
        {
            Vozilo vozilo = new Vozilo();
            using(RentACarEntities db=new RentACarEntities())
            {
                vozilo = (from v in db.Vozilo where v.VoziloID == iznajmljivanje.VoziloID select v).First();
            }
            return vozilo;
        }
        
    }

 
    public partial class Korisnik
    {
        /// <summary>
        /// Dohvaca korisnika po id za racunanje place i radi dohvacanje njegovih podataka
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static Korisnik DohvatiKorisnikaPoID(string ID)
        {
            Korisnik korisnik = new Korisnik();
            using (var db = new RentACarEntities())
            {
                BindingList<Korisnik> lista = new BindingList<Korisnik>((from k in db.Korisnik where (k.KorisnikID == ID) select k).ToList());
                foreach (var item in lista)
                {
                    korisnik = item;
                }
                return korisnik;
            }


        }

        public static Korisnik PrijavljeniKorisnik { get; set; }

        /// <summary>
        /// Vraća korisnika sa postavljenim korisničkim imenom i lozinkom 
        /// </summary>
        /// <param name="korisnickoIme">Korisničko ime korisnika</param>
        /// <param name="lozinka">Lozinka korisinika</param>
        /// <returns></returns>
        public static Korisnik DohvatiKorisnika(string korisnickoIme, string lozinka)
        {
            Korisnik korisnik = null;
            using (RentACarEntities db = new RentACarEntities())
            {
                korisnik = (from k in db.Korisnik where k.KorisnickoIme == korisnickoIme && k.Lozinka == lozinka select k).FirstOrDefault();
            }
            return korisnik;
        }
        /*
         * Dohvaća sve korisnike.
         */
         /// <summary>
         /// Dohvaća sve korisnike.
         /// </summary>
         /// <returns></returns>
        public static BindingList<Korisnik> DohvatiSveKorisnike()
        {
            BindingList<Korisnik> listaKorisnika = null;
            using(RentACarEntities db=new RentACarEntities())
            {
                listaKorisnika = new BindingList<Korisnik>((from k in db.Korisnik select k).ToList());
            }
            return listaKorisnika;
        }


        /// <summary>
        /// Metoda koja provjerava prilikom registracije dali je korisničko ime zauzeto 
        /// </summary>
        /// <param name="korisnickoIme"></param>
        /// <returns></returns>
        public static bool ProvjeriDostupnostKorisnickogImena(string korisnickoIme)
        {
            Korisnik korisnik = null;
            using (RentACarEntities db = new RentACarEntities())
            {
                korisnik = (from k in db.Korisnik where k.KorisnickoIme == korisnickoIme select k).FirstOrDefault();
            }
            if (korisnik != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Metoda koja provjerava prilikom registracije dali postoji korisnik s tim oibom u bazi
        /// </summary>
        /// <param name="oib"></param>
        /// <returns></returns>
        public static bool ProvjeriDostupnostOIB(string oib)
        {
            Korisnik korisnik = null;
            using (RentACarEntities db = new RentACarEntities())
            {
                korisnik = (from k in db.Korisnik where k.KorisnikID == oib select k).FirstOrDefault();
            }
            if (korisnik != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Metoda koja se koristi za dodavanje novog korisnika
        /// </summary>
        /// <param name="korisnik"> Korinsik kojeg treba dodati</param>
        public static void DodajKorisnika(Korisnik korisnik)
        {
            using (RentACarEntities db = new RentACarEntities())
            {
                db.Korisnik.Add(korisnik);
                db.SaveChanges();
            }
        }
        public static BindingList<Korisnik> dohvatiRadnike(int ID)
        {
            BindingList<Korisnik> listaRadnika = null;
            using (var db = new RentACarEntities())
            {
                listaRadnika = new BindingList<Korisnik>((from r in db.Korisnik where (r.TipKorisnika == ID) select r).ToList());
            }
            return listaRadnika;
        }


        public static Korisnik DohvatiKorisnikaPoSifriKorisnika(string sifra)
        {
            Korisnik korisnik = null;
            using(RentACarEntities db=new RentACarEntities())
            {
                korisnik = (from k in db.Korisnik where k.KorisnikID == sifra select k).FirstOrDefault();
            }
            return korisnik;
}
        /// <summary>
        /// Metoda koja dohvaća sve korisnike iz baze
        /// </summary>
        /// <returns></returns>

        public static BindingList<Korisnik> DohvatiKorisnike()
        {
            BindingList<Korisnik> listaKorinsika = null;
            using (var db = new RentACarEntities())
            {
                listaKorinsika = new BindingList<Korisnik>(db.Korisnik.ToList());
            }
            return listaKorinsika;

        }
    }

    public partial class Iznajmljivanje
    {
        /// <summary>
        /// Dohvaca sva iznajmljivanja od odabranog radnika u svrhu analize njihovog rada
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static BindingList<Iznajmljivanje> IznajmljivanjaRadnika(string ID)
        {
            BindingList<Iznajmljivanje> lista = null;
            using (var db = new RentACarEntities())
            {

                lista = new BindingList<Iznajmljivanje>((from u in db.Iznajmljivanje where (u.DjelatnikID == ID) select u).ToList());
            }
            return lista;


        }

        public static BindingList<Iznajmljivanje> Iznajmljivanja()
        {
            BindingList<Iznajmljivanje> lista = null;
            using (var db = new RentACarEntities())
            {

                lista = new BindingList<Iznajmljivanje>(db.Iznajmljivanje.ToList());
            }
            return lista;


        }

        public static BindingList<Iznajmljivanje> DohvatiIznajmljivanjaZaRacun()
        {
            BindingList<Iznajmljivanje> listaIznajmljivanja = null;
            using(RentACarEntities db=new RentACarEntities())
            {
                listaIznajmljivanja = new BindingList<Iznajmljivanje>((from i in db.Iznajmljivanje where i.Naplaceno==false select i).ToList());
            }
            return listaIznajmljivanja;
        }
        /// <summary>
        /// Metoda koja provjerava dali je vozilo iznajmljeno
        /// </summary>
        /// <param name="registracija">Registracija vozila kojeg provjeravamo</param>
        /// <returns></returns>
        public static bool ProvjeriZauzetostVozila(string registracija)
        {
            int broj;
            using (RentACarEntities db = new RentACarEntities())
            {
                broj = (from i in db.Iznajmljivanje where i.VoziloID == registracija select i).Count();
            }
            if (broj == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }

    public partial class Racun
    {

    }

    public partial class Rezervacija
    {
        /// <summary>
        /// Metoda koja provjerava dali je vozilo iznajmljeno
        /// </summary>
        /// <param name="registracija">Registracija vozila koje provjeravmo</param>
        /// <returns></returns>
        public static bool ProvjeriZauzetostVozila(string registracija)
        {
            int broj;
            using (RentACarEntities db = new RentACarEntities())
            {
                broj = (from i in db.Rezervacija where i.VoziloID == registracija select i).Count();
            }
            if (broj == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /*
         * Dohvaća sve rezervacije.
         */
         /// <summary>
         /// Dohvaća sve rezervacije.
         /// </summary>
         /// <returns></returns>
        public static BindingList<Rezervacija> DohvatiSveRezervacije()
        {
            BindingList<Rezervacija> listaRezervacija = null;
            using(RentACarEntities db=new RentACarEntities())
            {
                listaRezervacija = new BindingList<Rezervacija>((from r in db.Rezervacija select r).ToList());
            }
            return listaRezervacija;
        }

        public static BindingList<Rezervacija> DohvatiMojeRezervacije(Korisnik korisnik)
        {
            BindingList<Rezervacija> listaRezervacija = null;
            using(RentACarEntities db=new RentACarEntities())
            {
                listaRezervacija = new BindingList<Rezervacija>((from r in db.Rezervacija where r.KorisnikID == korisnik.KorisnikID select r).ToList());
            }
            return listaRezervacija;
        }

        /// <summary>
        /// Metoda koja dohvaće Rezervacije po datumu rezervacije
        /// </summary>
        /// <param name="vrijeme"> datum po kojem dohvaćamo</param>
        /// <returns></returns>
        public static BindingList<Rezervacija> DohvatiRezervacijePoDatumu(DateTime vrijeme)
        {
            BindingList<Rezervacija> lista = null;
            using (RentACarEntities db = new RentACarEntities())
            {
                lista = new BindingList<Rezervacija>((from r in db.Rezervacija where r.DatumPocetka.Year == vrijeme.Year && r.DatumPocetka.Month == vrijeme.Month select r).ToList());
            }
            return lista;

        }

    }

    public partial class Kategorija
    {
        /// <summary>
        /// Metoda koja dohvaća sve kategorije vozila
        /// </summary>
        /// <returns></returns>
        public static BindingList<Kategorija> DohvatiKategorije()
        {
            BindingList<Kategorija> lista = null;
            using (RentACarEntities db = new RentACarEntities())
            {
                lista = new BindingList<Kategorija>(db.Kategorija.ToList());
            }
            return lista;
        }
    }

    public partial class PovratnaInformacija
    {
        /// <summary>
        /// Lista koja se koristi za prikaz vozila
        /// </summary>
        /// <returns></returns>
        public static BindingList<Vozilo> PrikazVozila()
        {
            BindingList<Vozilo> lista = null;
            using (var db = new RentACarEntities())
            {
                lista = new BindingList<Vozilo>(db.Vozilo.ToList());
            }
            return lista;
        }

        /// <summary>
        /// LIsta koja se koristi za prikaz vozila u combo boxu a dohvaca ih pomocu ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static BindingList<PovratnaInformacija> PrikazVozilaPoID(string ID)
        {
            BindingList<PovratnaInformacija> lista = null;
            using (var db = new RentACarEntities())
            {
                lista = new BindingList<PovratnaInformacija>((from p in db.PovratnaInformacija where (p.VoziloID == ID) select p).ToList());
            }
            return lista;
        }

        /// <summary>
        /// Koristi ze za brisanje povratne informacije koja je prethodno odabrana
        /// </summary>
        /// <param name="ID"></param>
        public static void BrisanjePovratneInformacije(int ID)
        {
            using (var db = new RentACarEntities())
            {
                PovratnaInformacija povrat = null;
                BindingList<PovratnaInformacija> brisanje = new BindingList<PovratnaInformacija>((from p in db.PovratnaInformacija where (p.PovratnaInformacijaID == ID) select p).ToList());
                foreach (var item in brisanje)
                {
                    povrat = item;

                }
                db.PovratnaInformacija.Attach(povrat);
                db.PovratnaInformacija.Remove(povrat);
                db.SaveChanges();
            }

        }
        /// <summary>
        /// Lista koja vraca korisnike koji mogu ostaviti povratnu informaciju
        /// </summary>
        /// <returns></returns>
        public static BindingList<Korisnik> PrikazKorisnika()
        {
            BindingList<Korisnik> lista = null;
            using (var db = new RentACarEntities())
            {
                lista = new BindingList<Korisnik>(db.Korisnik.ToList());
            }
            return lista;
        }
        /// <summary>
        /// Metoda koja dodaje novo kreiranu povratnu informaciju u bazu
        /// </summary>
        /// <param name="povratnaInformacija"></param>
        public static void DodajPovratnuInformaciju(PovratnaInformacija povratnaInformacija)
        {
            using (var db = new RentACarEntities())
            {
                db.PovratnaInformacija.Add(povratnaInformacija);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Metoda koja dohvaca sve do sad  unesene povratne informacije
        /// </summary>
        /// <returns></returns>
        public static BindingList<PovratnaInformacija> PovratneInformacije()
        {
            BindingList<PovratnaInformacija> lista = null;
            using (var db = new RentACarEntities())
            {
                lista = new BindingList<PovratnaInformacija>(db.PovratnaInformacija.ToList());
            }
            return lista;
        }


    }

    public partial class Radi
    {


        public static BindingList<Radi> odradeneSmjene(string djelatnik, DateTime datum)
        {
            BindingList<Radi> listaSmjena = null;
            BindingList<Radi> listaSmjenaRadnika = new BindingList<Radi>();
            using (var db = new RentACarEntities())
            {

                listaSmjena = new BindingList<Radi>((from r in db.Radi where (r.DjelatnikID == djelatnik) select r).ToList());
            }
            foreach (var item in listaSmjena)
            {
                if (item.Datum.Month == datum.Month)
                {
                    listaSmjenaRadnika.Add(item);
                }
            }
            return listaSmjenaRadnika;


        }
        /// <summary>
        /// DOhvaca smjenu proslijedenog radnika
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static BindingList<Radi> DohvatiSmjeneRadnika(string ID)
        {
            BindingList<Radi> lista = null;
            using (var db = new RentACarEntities())
            {
                lista = new BindingList<Radi>((from r in db.Radi where (r.DjelatnikID == ID) select r).ToList());
            }
            return lista;
        }

        /// <summary>
        /// Metoda koja dodaje radnike smjeni(dodaje radnika u smjenu kojoj ce raditi)
        /// </summary>
        /// <param name="radi"></param>
        public static void DodajRadnikaSmjeni(Radi radi)
        {

            using (var db = new RentACarEntities())
            {
                db.Radi.Add(radi);
                db.SaveChanges();

            }
        }

        /// <summary>
        /// metotoda koja vraca listu zaposlenika u poduzecu
        /// </summary>
        /// <param name="smjena"></param>
        /// <param name="datum"></param>
        /// <returns></returns>
        public static BindingList<Korisnik> listaRadnika(int smjena, DateTime datum)
        {
            BindingList<Korisnik> listaRadnikaSmjene = null;
            BindingList<Korisnik> listaRadnikaSmjeneSvi = new BindingList<Korisnik>();
            BindingList<Radi> listaRadi = null;
            using (var db = new RentACarEntities())
            {
                listaRadi = new BindingList<Radi>((from r in db.Radi where (r.SmjenaID == smjena && r.Datum == datum) select r).ToList());
                foreach (var item in listaRadi)
                {
                    listaRadnikaSmjene = new BindingList<Korisnik>((from k in db.Korisnik where (k.KorisnikID == item.DjelatnikID) select k).ToList());
                    foreach (var item2 in listaRadnikaSmjene)
                    {
                        listaRadnikaSmjeneSvi.Add(item2);
                    }
                }
                
                return listaRadnikaSmjeneSvi;
            }
        }

        /// <summary>
        /// Metoda koja se koristi kod brisanja zaposlenika iz smjene u nekom odredenom danu
        /// </summary>
        /// <param name="smjena"></param>
        /// <param name="datum"></param>
        /// <param name="radnik"></param>
        public static void BrisanjeRadaUSmjeni(int smjena, DateTime datum, string radnik)
        {
            BindingList<Radi> listaRada = null;
            Radi radiBrisi = null;
            using (var db = new RentACarEntities())
            {

                listaRada = new BindingList<Radi>((from r in db.Radi where (r.SmjenaID == smjena && r.Datum == datum && r.DjelatnikID == radnik) select r).ToList());

                foreach (var item in listaRada)
                {
                    radiBrisi = item;
                }
                db.Radi.Attach(radiBrisi);
                db.Radi.Remove(radiBrisi);
                db.SaveChanges();
            }
            }
        }

        public partial class Smjena
    {
        /// <summary>
        /// Metoda koja sluzi za dodavanje smjene u poduzeću 
        /// </summary>
        /// <param name="smjena"></param>
        public static void DodajSmjenu(Smjena smjena)
        {

            using (var db = new RentACarEntities())
            {

                db.Smjena.Add(smjena);
                db.SaveChanges();
            }
        }
    }
    
    public partial class TipKorisnika
    {
        /// <summary>
        /// Metoda koja dohvaća sve tipove korisnika
        /// </summary>
        /// <returns></returns>
        public static BindingList<TipKorisnika> DohvatiTipoveKorisnika()
        {
            BindingList<TipKorisnika> tip = null;
            using (RentACarEntities db = new RentACarEntities())
            {
                tip = new BindingList<TipKorisnika>(db.TipKorisnika.ToList());
            }
            return tip;
        }
    }

    public partial class TipMotora
    {
        /// <summary>
        /// Metoda  koja dohvaća sve tipove motora
        /// </summary>
        /// <returns></returns>
        public static BindingList<TipMotora> DohvatiTipoveMotora()
        {
            BindingList<TipMotora> tip = null;
            using (RentACarEntities db = new RentACarEntities())
            {
                tip = new BindingList<TipMotora>(db.TipMotora.ToList());
            }
            return tip;
        }
    }
}
