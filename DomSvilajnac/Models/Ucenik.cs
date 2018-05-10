namespace DomSvilajnac.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Ucenici")]
    public class Ucenik
    {
        public int Id { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public string DatumRodjenja { get; set; }

        public string OtacIme { get; set; }

        public string OtacPrezime { get; set; }

        public string OtacObrazovanje { get; set; }

        public string MajkaIme { get; set; }

        public string MajkaPrezime { get; set; }

        public string MajkaObrazovanje { get; set; }

        public string MestoRodjenja { get; set; }

        public string OpstinaRodjenja { get; set; }

        public string DrzavaRodjenja { get; set; }

        public string DatumUseljenja { get; set; }

        public string BrojSobe { get; set; }

        public string BrojUMatKnjizi { get; set; }

        public string AdresaBoravka { get; set; }

        public string MobTelefon { get; set; }

        public string FiksniTelefon { get; set; }

        public string DatumNapustanja { get; set; }

        public string RazlogNapustanja { get; set; }

        public string Skola { get; set; }

        public string ObrazovniProfil { get; set; }

        public string Razred { get; set; }

        public string Odeljenje { get; set; }

        public string TelefonSkole { get; set; }

        public string OdeljenskiStaresina { get; set; }

        public string UspehPreRazred { get; set; }

        public string InteresovanjaHobi { get; set; }

        public string UcesceDom { get; set; }

        public string UcesceSkola { get; set; }

        public string UcesceGrad { get; set; }

        public string PohvaleDom { get; set; }

        public string PohvaleSkola { get; set; }

        public string PohvaleOstalo { get; set; }

        public string MeraOpomena { get; set; }

        public string MeraUkor { get; set; }

        public string UkorPredIskljucenje { get; set; }

        public string IskljucenjeIzDoma { get; set; }
    }
}
