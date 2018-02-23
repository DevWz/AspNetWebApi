namespace AspNetWebApi.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, unicode: false),
                        Senha = c.String(nullable: false),
                        Created = c.DateTime(nullable: false, defaultValue: DateTime.Now),
                        Modified = c.DateTime(nullable: false, defaultValue: DateTime.Now),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pedidos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Created = c.DateTime(nullable: false, defaultValue: DateTime.Now),
                        Modified = c.DateTime(nullable: false, defaultValue: DateTime.Now),
                        Cliente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .Index(t => t.Cliente_Id);
            
            CreateTable(
                "dbo.PedidoProdutos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Unid = c.Int(nullable: false),
                        Pedido_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pedidos", t => t.Pedido_Id, cascadeDelete: true)
                .Index(t => t.Pedido_Id);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Nome = c.String(nullable: false),
                        ImgUrl = c.String(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Created = c.DateTime(nullable: false, defaultValue: DateTime.Now),
                        Modified = c.DateTime(nullable: false, defaultValue: DateTime.Now),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PedidoProdutos", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtos", "Id", "dbo.PedidoProdutos");
            DropForeignKey("dbo.PedidoProdutos", "Pedido_Id", "dbo.Pedidos");
            DropForeignKey("dbo.Pedidos", "Cliente_Id", "dbo.Clientes");
            DropIndex("dbo.Produtos", new[] { "Id" });
            DropIndex("dbo.PedidoProdutos", new[] { "Pedido_Id" });
            DropIndex("dbo.Pedidos", new[] { "Cliente_Id" });
            DropTable("dbo.Produtos");
            DropTable("dbo.PedidoProdutos");
            DropTable("dbo.Pedidos");
            DropTable("dbo.Clientes");
        }
    }
}
