using Locadora.Models;
using Locadora.Respository;
using Locadora.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Locadora.API.Services
{
    public class UsuarioServices
    {
        private ApplicationDbContext _context = 
            new ApplicationDbContext();
        public Usuario CadastrarUsuario(UsuarioViewModel usuarioRecebeido)
        {
            Usuario usuario = new Usuario(usuarioRecebeido);
            _context.TabelaDeUsuarios.Add(usuario);
            return usuario;
        }
        public List<Usuario> ListarUsuarios()
        {
            return _context.TabelaDeUsuarios
                .OrderBy(usuario => usuario.Nome)
                .ThenBy(usuario => usuario.Idade)
                .ToList();
        }

        public Usuario ObterUsuario(string idRecebido)
        {
            List<Usuario> lista = ListarUsuarios();
            if(lista.Any(u => u.Id.ToString() == idRecebido))
            {
                Usuario usuario = lista
                   .Where(u => u.Id.ToString() == idRecebido)
                   .First();
                return usuario;
            }

            return null;
        }
    }
}
