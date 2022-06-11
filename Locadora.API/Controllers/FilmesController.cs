using Locadora.Models;
using Locadora.Services;
using Locadora.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Locadora.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        private GestaoServices _servico = new GestaoServices();
        
        [HttpPost]
        public IActionResult CadastrarFilme(FilmeViewModel filmeRecebido)
        {
            if(filmeRecebido == null)
            {
                return BadRequest("Por favor, informe o filme que deseja cadastrar.");
            }

            Filme filmeCadastrado = _servico.CadastrarFilme(filmeRecebido);

            return Created("filmes", filmeCadastrado); // 201
        }
    }
}
