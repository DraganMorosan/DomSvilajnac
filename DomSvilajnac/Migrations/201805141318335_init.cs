namespace DomSvilajnac.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ucenici",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pol = c.String(),
                        DatumUpisa = c.String(),
                        Ime = c.String(),
                        Prezime = c.String(),
                        DatumRodjenja = c.String(),
                        NosilacStarateljstva = c.String(),
                        StarateljIme = c.String(),
                        StarateljPrezime = c.String(),
                        NivoObrazovanja = c.String(),
                        MestoRodjenja = c.String(),
                        OpstinaRodjenja = c.String(),
                        DrzavaRodjenja = c.String(),
                        BrojUMatKnjizi = c.String(),
                        AdresaBoravka = c.String(),
                        Telefon = c.String(),
                        Skola = c.String(),
                        ObrazovniProfil = c.String(),
                        Razred = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ucenici");
        }
    }
}
