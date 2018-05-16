namespace DomSvilajnac.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodavanjeMB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ucenici", "MestoBoravka", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ucenici", "MestoBoravka");
        }
    }
}
