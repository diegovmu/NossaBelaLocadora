using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Locadora.Models
{
    public class Usuario
    {
        private readonly static int IDADE_MAIORIDADE = 18;

        public Usuario()
        {

        }
        public Usuario(UsuarioViewModel usuarioBase)
        {
            
            if (usuarioBase.Idade >= IDADE_MAIORIDADE)
            {
                Idade = usuarioBase.Idade;
                Conta = new Conta(50);
            }
            else
            {
                throw new Exception();
            }
            Nome = usuarioBase.Nome;
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        public int Idade { get; set; }
        public string Nome { get; set; }
        public Conta Conta { get; set; }

    }
}
