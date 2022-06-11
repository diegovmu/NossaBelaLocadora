using Locadora.Models;
using Locadora.Respository;
using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Services
{
    public class GestaoServices
    {
        private ApplicationDbContext _context = 
            new ApplicationDbContext();

        public Filme CadastrarFilme(FilmeViewModel filmeRecebido)
        {
            Filme filme = new Filme(filmeRecebido);

            filme.Titulo = filmeRecebido.Titulo;
            filme.Duracao = filmeRecebido.Duracao;
            filme.Descricao = filmeRecebido.Descricao;
            filme.QuantidadeDeOscars = filmeRecebido.QuantidadeDeOscars;
            filme.Quantidade = filmeRecebido.Quantidade;
            filme.Valor = filmeRecebido.Valor;
            
            _context.TabelaDeFilmes.Add(filme);
            _context.SaveChanges();

            return filme;
        }
        public Serie CadastrarSerie(SerieViewModel serieRecebida)
        {
            Serie serie = new Serie();
            serie.Titulo = serieRecebida.Titulo;
            serie.Descricao = serieRecebida.Descricao;
            serie.Valor = serieRecebida.Valor;
            serie.Temporadas = serieRecebida.Temporadas;

            _context.TabelaDeSeries.Add(serie);
            _context.SaveChanges();

            return serie;
        }

        public List<object> ListarItens()
        {
            List<object> nomeQualquer = 
                new List<object>();

            nomeQualquer.AddRange(_context.TabelaDeSeries);
            nomeQualquer.AddRange(_context.TabelaDeFilmes);

            return nomeQualquer;
        }
    }
}
