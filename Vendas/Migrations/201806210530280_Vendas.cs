namespace Vendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vendas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Cliente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .Index(t => t.Cliente_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendas", "Cliente_Id", "dbo.Clientes");
            DropIndex("dbo.Vendas", new[] { "Cliente_Id" });
            DropTable("dbo.Vendas");
        }
    }
}
