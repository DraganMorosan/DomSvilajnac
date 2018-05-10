namespace DomSvilajnac.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ucenici",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Prezime = c.String(),
                        DatumRodjenja = c.String(),
                        OtacIme = c.String(),
                        OtacPrezime = c.String(),
                        OtacObrazovanje = c.String(),
                        MajkaIme = c.String(),
                        MajkaPrezime = c.String(),
                        MajkaObrazovanje = c.String(),
                        MestoRodjenja = c.String(),
                        OpstinaRodjenja = c.String(),
                        DrzavaRodjenja = c.String(),
                        DatumUseljenja = c.String(),
                        BrojSobe = c.String(),
                        BrojUMatKnjizi = c.String(),
                        AdresaBoravka = c.String(),
                        MobTelefon = c.String(),
                        FiksniTelefon = c.String(),
                        DatumNapustanja = c.String(),
                        RazlogNapustanja = c.String(),
                        Skola = c.String(),
                        ObrazovniProfil = c.String(),
                        Razred = c.String(),
                        Odeljenje = c.String(),
                        TelefonSkole = c.String(),
                        OdeljenskiStaresina = c.String(),
                        UspehPreRazred = c.String(),
                        InteresovanjaHobi = c.String(),
                        UcesceDom = c.String(),
                        UcesceSkola = c.String(),
                        UcesceGrad = c.String(),
                        PohvaleDom = c.String(),
                        PohvaleSkola = c.String(),
                        PohvaleOstalo = c.String(),
                        MeraOpomena = c.String(),
                        MeraUkor = c.String(),
                        UkorPredIskljucenje = c.String(),
                        IskljucenjeIzDoma = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ucenici");
        }
    }
}
