namespace AspNetWebApi.Core.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AspNetWebApi.Core.Models.DB.AspNetWebApiDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AspNetWebApi.Core.Models.DB.AspNetWebApiDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Clientes.AddOrUpdate(x => x.Id,
                new Models.Cliente() { Email = "mail@mail.com", Senha = "123" }
                );

            context.Produtos.AddOrUpdate(x => x.Id,
                new Models.Produto() { Nome = "Arroz", Preco = 9.60m },
                new Models.Produto() { Nome = "Feijão", Preco = 6.42m },
                new Models.Produto() { Nome = "Macarrão", Preco = 4.69m },
                new Models.Produto() { Nome = "Refrigerante", Preco = 7.72m },
                new Models.Produto() { Nome = "Café", Preco = 7.50m },
                new Models.Produto() { Nome = "Açucar", Preco = 3.47m }
                );

        }
    }
}
