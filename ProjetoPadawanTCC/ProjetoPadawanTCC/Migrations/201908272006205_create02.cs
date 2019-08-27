namespace ProjetoPadawanTCC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create02 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Periodos",
                c => new
                    {
                        CodigoPeriodo = c.Int(nullable: false, identity: true),
                        DataInicio = c.DateTime(nullable: false),
                        DataFim = c.DateTime(nullable: false),
                        CodigoTipo_CodigoTipo = c.Int(),
                    })
                .PrimaryKey(t => t.CodigoPeriodo)
                .ForeignKey("dbo.TipoVeiculos", t => t.CodigoTipo_CodigoTipo)
                .Index(t => t.CodigoTipo_CodigoTipo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Periodos", "CodigoTipo_CodigoTipo", "dbo.TipoVeiculos");
            DropIndex("dbo.Periodos", new[] { "CodigoTipo_CodigoTipo" });
            DropTable("dbo.Periodos");
        }
    }
}
