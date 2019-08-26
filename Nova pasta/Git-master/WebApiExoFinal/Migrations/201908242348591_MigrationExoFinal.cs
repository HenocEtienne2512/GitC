namespace WebApiExoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationExoFinal : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeCompleto = c.String(),
                        EstadoCivil = c.String(),
                        Rg = c.String(),
                        Cpf = c.String(),
                        Cnpj = c.String(),
                        NomeFantasia = c.String(),
                        Cep = c.String(),
                        Endereco = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        Fone = c.String(),
                        Celular = c.String(),
                        Email = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
        }
    }
}
