using GestaoDeTarefas.Domain.Enums;

namespace GestaoDeTarefas.Domain.Entities;

public class Tarefa(string titulo, string? descricao, DateTimeOffset? dataDeVencimento, StatusTarefa? status)
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public required string Titulo { get; set; } = titulo;
    public string? Descricao { get; set; } = descricao;
    public DateTimeOffset? DataDeVencimento { get; set; } = dataDeVencimento;
    public StatusTarefa? Status { get; set; } = status ?? StatusTarefa.Pendente;
}