namespace WebMvcApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Henoc02 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Carroes", "Placa", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Carroes", "Placa", c => c.Int(nullable: false));
        }
    }
}
