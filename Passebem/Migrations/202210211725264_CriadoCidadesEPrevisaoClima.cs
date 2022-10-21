namespace Passebem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriadoCidadesEPrevisaoClima : DbMigration
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
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PrevisaoClima");
            DropTable("dbo.Cidade");
        }
    }
}
