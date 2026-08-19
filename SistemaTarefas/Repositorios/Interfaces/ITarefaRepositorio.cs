using Microsoft.AspNetCore.Http.HttpResults;
using SistemaTarefas.Models;

namespace SistemaTarefas.Repositorios.Interfaces
{
    public interface ITarefaRepositorio
    {

        Task<List<TarefaModel>> BuscarTodasTarefas();
        Task<TarefaModel> BuscarPorId(int id);
        Task<TarefaModel> Adicionar(TarefaModel tarefa);
        Task<TarefaModel> Atualizar(TarefaModel tarefa, int id);
        Task<bool> Apagar(int id);
    }
}
