namespace ProjetoPadawanTCC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cores",
                c => new
                    {
                        CodigoCor = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CodigoCor);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        CodigoMarca = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        CodigoTipo_CodigoTipo = c.Int(),
                    })
                .PrimaryKey(t => t.CodigoMarca)
                .ForeignKey("dbo.TipoVeiculos", t => t.CodigoTipo_CodigoTipo)
                .Index(t => t.CodigoTipo_CodigoTipo);
            
            CreateTable(
                "dbo.TipoVeiculos",
                c => new
                    {
                        CodigoTipo = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CodigoTipo);
            
            CreateTable(
                "dbo.Modelos",
                c => new
                    {
                        CodigoModelo = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        CodigoMarca_CodigoMarca = c.Int(),
                        veiculos_CodigoTipo = c.Int(),
                    })
                .PrimaryKey(t => t.CodigoModelo)
                .ForeignKey("dbo.Marcas", t => t.CodigoMarca_CodigoMarca)
                .ForeignKey("dbo.TipoVeiculos", t => t.veiculos_CodigoTipo)
                .Index(t => t.CodigoMarca_CodigoMarca)
                .Index(t => t.veiculos_CodigoTipo);
            
            CreateTable(
                "dbo.Veiculos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Placa = c.String(),
                        CodigoCor_CodigoCor = c.Int(),
                        CodigoMarca_CodigoMarca = c.Int(),
                        CodigoModelo_CodigoModelo = c.Int(),
                        codigoTipo_CodigoTipo = c.Int(),
                        CodUsu_CodUsu = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cores", t => t.CodigoCor_CodigoCor)
                .ForeignKey("dbo.Marcas", t => t.CodigoMarca_CodigoMarca)
                .ForeignKey("dbo.Modelos", t => t.CodigoModelo_CodigoModelo)
                .ForeignKey("dbo.TipoVeiculos", t => t.codigoTipo_CodigoTipo)
                .ForeignKey("dbo.Usuarios", t => t.CodUsu_CodUsu)
                .Index(t => t.CodigoCor_CodigoCor)
                .Index(t => t.CodigoMarca_CodigoMarca)
                .Index(t => t.CodigoModelo_CodigoModelo)
                .Index(t => t.codigoTipo_CodigoTipo)
                .Index(t => t.CodUsu_CodUsu);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        CodUsu = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Idade = c.Int(nullable: false),
                        Email = c.String(),
                        IsPcd = c.Boolean(nullable: false),
                        IsMinicipio = c.Boolean(nullable: false),
                        OferCarona = c.Boolean(nullable: false),
                        Tipo = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CodUsu);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Veiculos", "CodUsu_CodUsu", "dbo.Usuarios");
            DropForeignKey("dbo.Veiculos", "codigoTipo_CodigoTipo", "dbo.TipoVeiculos");
            DropForeignKey("dbo.Veiculos", "CodigoModelo_CodigoModelo", "dbo.Modelos");
            DropForeignKey("dbo.Veiculos", "CodigoMarca_CodigoMarca", "dbo.Marcas");
            DropForeignKey("dbo.Veiculos", "CodigoCor_CodigoCor", "dbo.Cores");
            DropForeignKey("dbo.Modelos", "veiculos_CodigoTipo", "dbo.TipoVeiculos");
            DropForeignKey("dbo.Modelos", "CodigoMarca_CodigoMarca", "dbo.Marcas");
            DropForeignKey("dbo.Marcas", "CodigoTipo_CodigoTipo", "dbo.TipoVeiculos");
            DropIndex("dbo.Veiculos", new[] { "CodUsu_CodUsu" });
            DropIndex("dbo.Veiculos", new[] { "codigoTipo_CodigoTipo" });
            DropIndex("dbo.Veiculos", new[] { "CodigoModelo_CodigoModelo" });
            DropIndex("dbo.Veiculos", new[] { "CodigoMarca_CodigoMarca" });
            DropIndex("dbo.Veiculos", new[] { "CodigoCor_CodigoCor" });
            DropIndex("dbo.Modelos", new[] { "veiculos_CodigoTipo" });
            DropIndex("dbo.Modelos", new[] { "CodigoMarca_CodigoMarca" });
            DropIndex("dbo.Marcas", new[] { "CodigoTipo_CodigoTipo" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Veiculos");
            DropTable("dbo.Modelos");
            DropTable("dbo.TipoVeiculos");
            DropTable("dbo.Marcas");
            DropTable("dbo.Cores");
        }
    }
}
