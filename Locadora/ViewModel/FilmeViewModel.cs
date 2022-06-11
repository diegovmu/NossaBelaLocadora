using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Locadora.ViewModel
{
    // É o que o usuário vai mandar pro
    // seu programa
    public class FilmeViewModel
    {
        public string Titulo { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public int Valor { get; set; }
        public int Duracao { get; set; }
        public int QuantidadeDeOscars { get; set; }
        public string GeneroDoFilme { get; set; }
    }
}
