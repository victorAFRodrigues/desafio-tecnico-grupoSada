using GestaoDeTarefas.Domain.Entities;
using GestaoDeTarefas.Domain.Filters;

namespace GestaoDeTarefas.Domain.Interfaces;

public interface ITarefaRepository
{
    Task<Tarefa> Add(Tarefa tarefa);
    
    Task<IEnumerable<Tarefa>> Get(TarefaFilters filtros);
    
    Task<Tarefa> GetById(Guid id);
    
    Task Update(Tarefa tarefa);
    
    Task Delete(Guid id);
}