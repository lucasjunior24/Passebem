namespace Passebem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtualizadoEstados : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cidade", "Estado_Id", c => c.Int());
            CreateIndex("dbo.Cidade", "Estado_Id");
            AddForeignKey("dbo.Cidade", "Estado_Id", "dbo.Estado", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cidade", "Estado_Id", "dbo.Estado");
            DropIndex("dbo.Cidade", new[] { "Estado_Id" });
            DropColumn("dbo.Cidade", "Estado_Id");
        }
    }
}
