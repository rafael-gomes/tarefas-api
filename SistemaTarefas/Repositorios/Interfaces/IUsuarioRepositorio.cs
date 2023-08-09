using SistemaTarefas.Models;

namespace SistemaTarefas.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<MUsuario>> BuscarTodosUsuarios();
        Task<MUsuario> BuscarPorId(int id);
        Task<MUsuario> Adicionar(MUsuario usuario);
        Task<MUsuario> Atualizar(MUsuario usuario, int id);
        Task<bool> Apagar(int id);
    }
}
