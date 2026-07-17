using GestaoDeTarefas.Domain.Entities;
using GestaoDeTarefas.Domain.Filters;
using GestaoDeTarefas.Domain.Interfaces;
using GestaoDeTarefas.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeTarefas.Infrastructure.Repositories;

public class TarefaRepository(AppDbContext context): ITarefaRepository
{
    public async Task<Tarefa> Add(Tarefa tarefa)
    {
        await context.Tarefas.AddAsync(tarefa);
        await context.SaveChangesAsync();
        return tarefa;
    }

    public async Task<IEnumerable<Tarefa>> Get(TarefaFilters tarefaFilter)
    {
        IQueryable<Tarefa> query = context.Tarefas;
        
        // "Encadeamento de Ifs para melhor legibilidade
        if(tarefaFilter.Status.HasValue)
        {
            query = query.Where(tarefa => tarefa.Status == tarefaFilter.Status);
        }

        if(tarefaFilter.DataDe.HasValue)
        {
            query = query.Where(tarefa => tarefa.DataDeVencimento >= tarefaFilter.DataDe);
        }
        
        if(tarefaFilter.DataAte.HasValue)
        {
            query = query.Where(tarefa => tarefa.DataDeVencimento <= tarefaFilter.DataAte);
        }
        
        return await query.ToListAsync();
    }

    public async Task<Tarefa> GetById(Guid id)
    {
        var tarefa = await context.Tarefas.FirstOrDefaultAsync(tarefa => tarefa.Id == id);
        
        return tarefa ?? throw new KeyNotFoundException($"Tarefa {id} not found");
    }

    public async Task Update(Tarefa tarefa)
    {   
        var tarefaExists = context.Tarefas.FirstOrDefault(t => t.Id == tarefa.Id);

        if (tarefaExists is null)
        {
            throw new KeyNotFoundException($"Tarefa {tarefa.Id} not found");
        }
        
        context.Tarefas.Update(tarefa);
        await context.SaveChangesAsync(); ;
    }

    public async Task Delete(Guid id)
    {
        var tarefa = await context.Tarefas.FindAsync(id);
        if (tarefa is not null)
        {
            context.Tarefas.Remove(tarefa);
            await context.SaveChangesAsync();
        }
    }

}