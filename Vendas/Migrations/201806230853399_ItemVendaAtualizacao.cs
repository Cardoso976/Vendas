namespace Vendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItemVendaAtualizacao : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ItemVendas", "Produto_Id", "dbo.Produtos");
            DropForeignKey("dbo.ItemVendas", "Venda_Id", "dbo.Vendas");
            DropIndex("dbo.ItemVendas", new[] { "Produto_Id" });
            DropIndex("dbo.ItemVendas", new[] { "Venda_Id" });
            RenameColumn(table: "dbo.ItemVendas", name: "Produto_Id", newName: "ProdutoId");
            RenameColumn(table: "dbo.ItemVendas", name: "Venda_Id", newName: "VendaId");
            AlterColumn("dbo.ItemVendas", "ProdutoId", c => c.Int(nullable: false));
            AlterColumn("dbo.ItemVendas", "VendaId", c => c.Int(nullable: false));
            CreateIndex("dbo.ItemVendas", "ProdutoId");
            CreateIndex("dbo.ItemVendas", "VendaId");
            AddForeignKey("dbo.ItemVendas", "ProdutoId", "dbo.Produtos", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ItemVendas", "VendaId", "dbo.Vendas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemVendas", "VendaId", "dbo.Vendas");
            DropForeignKey("dbo.ItemVendas", "ProdutoId", "dbo.Produtos");
            DropIndex("dbo.ItemVendas", new[] { "VendaId" });
            DropIndex("dbo.ItemVendas", new[] { "ProdutoId" });
            AlterColumn("dbo.ItemVendas", "VendaId", c => c.Int());
            AlterColumn("dbo.ItemVendas", "ProdutoId", c => c.Int());
            RenameColumn(table: "dbo.ItemVendas", name: "VendaId", newName: "Venda_Id");
            RenameColumn(table: "dbo.ItemVendas", name: "ProdutoId", newName: "Produto_Id");
            CreateIndex("dbo.ItemVendas", "Venda_Id");
            CreateIndex("dbo.ItemVendas", "Produto_Id");
            AddForeignKey("dbo.ItemVendas", "Venda_Id", "dbo.Vendas", "Id");
            AddForeignKey("dbo.ItemVendas", "Produto_Id", "dbo.Produtos", "Id");
        }
    }
}
