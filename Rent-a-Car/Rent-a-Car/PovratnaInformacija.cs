//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rent_a_Car
{
    using System;
    using System.Collections.Generic;
    
    public partial class PovratnaInformacija
    {
        public int PovratnaInformacijaID { get; set; }
        public string Opis { get; set; }
        public int Ocjena { get; set; }
        public string VoziloID { get; set; }
        public string KorisnikID { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        public virtual Vozilo Vozilo { get; set; }
    }
}
