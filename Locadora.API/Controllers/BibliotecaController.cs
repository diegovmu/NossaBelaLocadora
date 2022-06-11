using Locadora.Models;
using Locadora.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Locadora.API.Controllers
{
    [ApiController]
    [Route("biblioteca")]
    public class BibliotecaController : ControllerBase
    {
        private GestaoServices _servico = new GestaoServices();
        
        [HttpGet]
        public IActionResult ObterBiblioteca()
        {
            List<object> itens = _servico.ListarItens();

            return Ok(itens);
        }
    }
}
