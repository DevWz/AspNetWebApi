using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetWebApi.Core.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }
        
        [Required]
        public DateTime Created { get; set; }

        [Required]
        public DateTime Modified { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

    }
}
