using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetWebApi.Core.Models
{
    public class Venda
    {
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }
        public int Unid { get; set; }
        public decimal Preco { get; set; }
    }
}
