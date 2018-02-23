using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetWebApi.Core.Models
{
    public class PedidoProduto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal Preco { get; set; }

        [Required]
        public int Unid { get; set; }

        public virtual Pedido Pedido { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
