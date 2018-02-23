namespace AspNetWebApi.Core.Models.DB
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AspNetWebApiDbContext : DbContext
    {
        // Your context has been configured to use a 'AspNetWebApiDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'AspNetWebApi.Core.Models.DB.AspNetWebApiDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'AspNetWebApiDbContext' 
        // connection string in the application configuration file.
        public AspNetWebApiDbContext()
            : base("name=AspNetWebApiDbContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<PedidoProduto> PedidoProdutos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>()
                .Property(x => x.Email)
                .IsUnicode(false);

            // One-to-Many
            // Clientes podem ter muitos Pedidos
            modelBuilder.Entity<Pedido>()
                // .HasRequired<Cliente>(x => x.Cliente) // Cliente obrigatorio para Pedido
                .HasOptional<Cliente>(x => x.Cliente) // Cliente opcional para Pedido // Soluciona problema da Null FK quando Cliente é deletado
                .WithMany(x => x.Pedidos); // Multiplos Pedidos permitidos para Cliente

            // One-to-Many
            // Pedidos podem ter muitos PedidoProdutos
            modelBuilder.Entity<PedidoProduto>()
                .HasRequired<Pedido>(x => x.Pedido) // Pedido obrigatorio para PedidoItem
                .WithMany(x => x.PedidoProdutos); // Multiplos PedidoItem para Pedido

            // One-to-Zero-or-One
            // PedidoProduto pode ou não ter um Produto
            modelBuilder.Entity<PedidoProduto>()
                .HasOptional(x => x.Produto)
                .WithRequired(x => x.PedidoProduto);

            modelBuilder.Entity<Cliente>()
                .ToTable("Clientes");

            modelBuilder.Entity<Produto>()
                .ToTable("Produtos");

            modelBuilder.Entity<Pedido>()
                .ToTable("Pedidos");

            modelBuilder.Entity<PedidoProduto>()
                .ToTable("PedidoProdutos");

        }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}