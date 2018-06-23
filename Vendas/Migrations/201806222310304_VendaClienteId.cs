namespace Vendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VendaClienteId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vendas", "Cliente_Id", "dbo.Clientes");
            DropIndex("dbo.Vendas", new[] { "Cliente_Id" });
            RenameColumn(table: "dbo.Vendas", name: "Cliente_Id", newName: "ClienteId");
            AlterColumn("dbo.Vendas", "ClienteId", c => c.Int(nullable: false));
            CreateIndex("dbo.Vendas", "ClienteId");
            AddForeignKey("dbo.Vendas", "ClienteId", "dbo.Clientes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendas", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Vendas", new[] { "ClienteId" });
            AlterColumn("dbo.Vendas", "ClienteId", c => c.Int());
            RenameColumn(table: "dbo.Vendas", name: "ClienteId", newName: "Cliente_Id");
            CreateIndex("dbo.Vendas", "Cliente_Id");
            AddForeignKey("dbo.Vendas", "Cliente_Id", "dbo.Clientes", "Id");
        }
    }
}
