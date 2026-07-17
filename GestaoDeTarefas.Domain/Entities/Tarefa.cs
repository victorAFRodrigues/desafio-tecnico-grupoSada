using GestaoDeTarefas.Domain.Enums;

namespace GestaoDeTarefas.Domain.Entities;

public class Tarefa
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Titulo { get; set; }
    public string? Descricao { get; set; } = null;
    public DateTimeOffset? DataDeVencimento { get; set; } = null;
    public StatusTarefa Status { get; set; } = StatusTarefa.Pendente;
    
    
}