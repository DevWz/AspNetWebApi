using AspNetWebApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetWepApi.Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            AspNetWebApi.Core.Models.DB.AspNetWebApiDbContext manager = new AspNetWebApi.Core.Models.DB.AspNetWebApiDbContext();

            // Cliente cliente = manager.Clientes.SingleOrDefault(x => x.Id.Equals(1));

            Cliente cliente = new Cliente()
            {
                Email = "admin@admin.com",
                Senha = "123",
                Pedidos = new List<Pedido>()
                {
                    new Pedido()
                    {
                        PedidoProdutos = new List<PedidoProduto>()
                        {
                            new PedidoProduto() { Unid = 10, Preco = 10.00m },
                            new PedidoProduto() { Unid = 10, Preco = 10.00m },
                            new PedidoProduto() { Unid = 10, Preco = 10.00m },
                            new PedidoProduto() { Unid = 10, Preco = 10.00m },
                            new PedidoProduto() { Unid = 10, Preco = 10.00m },
                            new PedidoProduto() { Unid = 10, Preco = 10.00m },
                        }
                    },
                    new Pedido()
                    {
                        PedidoProdutos = new List<PedidoProduto>()
                        {
                            new PedidoProduto() { Unid = 10, Preco = 10.00m },
                            new PedidoProduto() { Unid = 10, Preco = 10.00m },
                            new PedidoProduto() { Unid = 10, Preco = 10.00m },
                            new PedidoProduto() { Unid = 10, Preco = 10.00m },
                            new PedidoProduto() { Unid = 10, Preco = 10.00m },
                            new PedidoProduto() { Unid = 10, Preco = 10.00m },
                        }
                    }
                }
            };

            if (cliente != null)
            {

                // OK
                /*
                Pedido pedido = new Pedido()
                {
                    Cliente = cliente,
                    PedidoProdutos = new List<PedidoProduto>()
                    {
                        new PedidoProduto() { Preco = 4.00m, Unid = 10 },
                        new PedidoProduto() { Preco = 5.62m, Unid = 2}
                    },
                };
                */
                // manager.Pedidos.Add(pedido);

                manager.Clientes.Add(cliente);
                manager.SaveChanges();

            }

        }
    }
}
