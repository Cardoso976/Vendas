namespace Vendas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Produtos1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produtoes", "Descricao", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produtoes", "Descricao", c => c.String(maxLength: 100));
        }
    }
}
