using Locadora.Services;
using Locadora.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Locadora.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        private GestaoServices _gestaoServices;
        
        public SeriesController()
        {
            _gestaoServices = new GestaoServices();
        }

        [HttpPost]
        public IActionResult CadastrarSerie(SerieViewModel serieRecebida)
        {
            if(serieRecebida == null)
            {
                return BadRequest("Erro ao cadastrar série, ela está vazia"); ;
            }

            _gestaoServices.CadastrarSerie(serieRecebida);

            return Created("series", serieRecebida);
        }
    }
}
