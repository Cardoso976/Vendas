namespace Vendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItensVenda : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemVendas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        ValorUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Produto_Id = c.Int(),
                        Venda_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produtoes", t => t.Produto_Id)
                .ForeignKey("dbo.Vendas", t => t.Venda_Id)
                .Index(t => t.Produto_Id)
                .Index(t => t.Venda_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemVendas", "Venda_Id", "dbo.Vendas");
            DropForeignKey("dbo.ItemVendas", "Produto_Id", "dbo.Produtoes");
            DropIndex("dbo.ItemVendas", new[] { "Venda_Id" });
            DropIndex("dbo.ItemVendas", new[] { "Produto_Id" });
            DropTable("dbo.ItemVendas");
        }
    }
}
