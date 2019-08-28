namespace ProjetoPadawanTCC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create04 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Periodos", "Vigente", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Periodos", "Vigente");
        }
    }
}
