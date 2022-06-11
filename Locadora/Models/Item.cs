using Locadora.Respository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Locadora.Models
{
    public class Item
    {
        [Key]
        public Guid Id { get; set; }
        public int Quantidade { get; set; }
        public int Valor { get; set; }

        [Required] // Data Notations
        [MinLength(3)]
        [MaxLength(50)]
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public Item()
        {
            Id = Guid.NewGuid();
        }
    }
}
