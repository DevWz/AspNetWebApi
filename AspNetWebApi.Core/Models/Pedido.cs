using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetWebApi.Core.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }

        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }

        public Cliente Cliente { get; set; }
    }
}
