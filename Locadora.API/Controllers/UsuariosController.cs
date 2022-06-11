using Locadora.API.Services;
using Locadora.Models;
using Locadora.Respository;
using Locadora.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Locadora.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {
        private UsuarioServices _usuarioServices =
            new UsuarioServices();

        [HttpPost]
        public ActionResult CadastrarUsuario(
            [FromBody] UsuarioViewModel usuarioRecebido)
        {
            if (usuarioRecebido == null) {
                return BadRequest("Não foi recebido nenhum usuário.");
            }

            if (string.IsNullOrEmpty(usuarioRecebido.Nome)) {
                return BadRequest("Nome do usuário não foi informado. 🥲");
            }

            if (usuarioRecebido.Idade < 18) {
                return BadRequest("Não é permitido o cadastro de pessoas menores de idade");
            }

            Usuario objetoCriado = _usuarioServices
                .CadastrarUsuario(usuarioRecebido);

            return Created("usuarios", objetoCriado);
        }

        [HttpGet]
        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> listaUsuario =
                _usuarioServices.ListarUsuarios();
            return listaUsuario;
        }

        [HttpGet("{id}")] //CONTROLADORA
        public IActionResult ObterUsuario(string id)
        {
            Usuario usuario = _usuarioServices.ObterUsuario(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);

        }
    }
}
