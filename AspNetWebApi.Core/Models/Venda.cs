using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetWebApi.Core.Models
{
    public class Venda
    {
        [ForeignKey("Pedido")]
        public int IdPedido { get; set; }

        [ForeignKey("Produto")]
        public int IdProduto { get; set; }

        [Required]
        public int Unid { get; set; }

        [Required]
        public decimal Preco { get; set; }
    }
}
