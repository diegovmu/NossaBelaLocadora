using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Models
{
    public class Filme : Item
    {
        public Filme()
        {

        }

        public Filme(FilmeViewModel filmeRecebido)
        {
            Duracao = filmeRecebido.Duracao;
            QuantidadeDeOscars = filmeRecebido.QuantidadeDeOscars;
        }
      
        public int Duracao { get; set; }
        public int QuantidadeDeOscars { get; set; }
        public Guid IdFilme { get; set; }

    }
}
