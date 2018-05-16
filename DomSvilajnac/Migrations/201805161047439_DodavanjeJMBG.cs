namespace DomSvilajnac.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodavanjeJMBG : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ucenici", "JMBG", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ucenici", "JMBG");
        }
    }
}
