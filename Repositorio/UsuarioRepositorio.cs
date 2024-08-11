using JoinBike_Site.Models;
using JoinBike_SITE.Data;

namespace JoinBike_SITE.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {   
        private readonly BancoContext _bancoContext;

        public UsuarioRepositorio(BancoContext bancoContext) 
        {
            _bancoContext = bancoContext;
        }

        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            _bancoContext.Usuario.Add(usuario);
            _bancoContext.SaveChanges();
            return usuario;
        }
    }
}
