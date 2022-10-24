namespace Passebem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cidade",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        EstadoId = c.String(),
                        Estado_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estado", t => t.Estado_Id)
                .Index(t => t.Estado_Id);
            
            CreateTable(
                "dbo.Estado",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        UF = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PrevisaoClima",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Clima = c.Int(nullable: false),
                        CidadeId = c.Int(nullable: false),
                        DataPrevisao = c.DateTime(nullable: false),
                        TemperaturaMaxima = c.Int(nullable: false),
                        TemperaturaMinima = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cidade", t => t.CidadeId, cascadeDelete: true)
                .Index(t => t.CidadeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PrevisaoClima", "CidadeId", "dbo.Cidade");
            DropForeignKey("dbo.Cidade", "Estado_Id", "dbo.Estado");
            DropIndex("dbo.PrevisaoClima", new[] { "CidadeId" });
            DropIndex("dbo.Cidade", new[] { "Estado_Id" });
            DropTable("dbo.PrevisaoClima");
            DropTable("dbo.Estado");
            DropTable("dbo.Cidade");
        }
    }
}
