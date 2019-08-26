namespace WEBAPIRESTFULL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Generos", "Ativo", c => c.Boolean());
            AddColumn("dbo.Generos", "UsuInc", c => c.Int());
            AddColumn("dbo.Generos", "UsuAlt", c => c.Int());
            AddColumn("dbo.Generos", "DatInc", c => c.DateTime());
            AddColumn("dbo.Generos", "DatAlt", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Generos", "DatAlt");
            DropColumn("dbo.Generos", "DatInc");
            DropColumn("dbo.Generos", "UsuAlt");
            DropColumn("dbo.Generos", "UsuInc");
            DropColumn("dbo.Generos", "Ativo");
        }
    }
}
