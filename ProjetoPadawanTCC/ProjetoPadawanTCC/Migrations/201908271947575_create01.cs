namespace ProjetoPadawanTCC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create01 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Modelos", name: "veiculos_CodigoTipo", newName: "CodigoTipo_CodigoTipo");
            RenameIndex(table: "dbo.Modelos", name: "IX_veiculos_CodigoTipo", newName: "IX_CodigoTipo_CodigoTipo");
            CreateTable(
                "dbo.TermoUsoes",
                c => new
                    {
                        CodigoTermo = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 2500),
                        Vigente = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CodigoTermo);
            
            AddColumn("dbo.Usuarios", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Usuarios", "Idade", c => c.Int());
            AlterColumn("dbo.Usuarios", "IsPcd", c => c.Boolean());
            AlterColumn("dbo.Usuarios", "IsMinicipio", c => c.Boolean());
            AlterColumn("dbo.Usuarios", "OferCarona", c => c.Boolean());
            DropColumn("dbo.Usuarios", "Ativo");
            DropColumn("dbo.Usuarios", "UsuarioCriacao");
            DropColumn("dbo.Usuarios", "UsuarioAlteracao");
            DropColumn("dbo.Usuarios", "DataCriacao");
            DropColumn("dbo.Usuarios", "DataAlteracao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "DataAlteracao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Usuarios", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Usuarios", "UsuarioAlteracao", c => c.Int(nullable: false));
            AddColumn("dbo.Usuarios", "UsuarioCriacao", c => c.Int(nullable: false));
            AddColumn("dbo.Usuarios", "Ativo", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Usuarios", "OferCarona", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Usuarios", "IsMinicipio", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Usuarios", "IsPcd", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Usuarios", "Idade", c => c.Int(nullable: false));
            DropColumn("dbo.Usuarios", "Discriminator");
            DropTable("dbo.TermoUsoes");
            RenameIndex(table: "dbo.Modelos", name: "IX_CodigoTipo_CodigoTipo", newName: "IX_veiculos_CodigoTipo");
            RenameColumn(table: "dbo.Modelos", name: "CodigoTipo_CodigoTipo", newName: "veiculos_CodigoTipo");
        }
    }
}
