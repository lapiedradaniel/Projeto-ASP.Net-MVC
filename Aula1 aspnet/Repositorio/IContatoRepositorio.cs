using Aula1_aspnet.Models;

namespace Aula1_aspnet.Repositorio
{
    public interface IContatoRepositorio
    {

        ContatoModel ListarPorId(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar(int id);
    }
}
