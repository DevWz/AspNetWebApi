using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetWebApi.Core.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string ImgUrl { get; set; }

        [Required]
        public decimal Preco { get; set; }

        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
