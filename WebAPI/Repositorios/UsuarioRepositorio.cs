using WebAPI.Repositorios.Interfaces;
using WebAPI.Models;

namespace WebAPI.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public UsuarioRepositorio()
        {

        }
        public Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            throw new NotImplementedException();
        }
        public Task<UsuarioModel> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }
        public Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            throw new NotImplementedException();
        }
        public Task<bool> Apagar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
