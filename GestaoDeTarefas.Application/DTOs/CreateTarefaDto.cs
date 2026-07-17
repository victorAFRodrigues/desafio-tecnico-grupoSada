using GestaoDeTarefas.Domain.Enums;

namespace GestaoDeTarefas.Application.DTOs;

public record CreateTarefaDto(string Titulo, string? Descricao, DateTimeOffset? DataDeVencimento, StatusTarefa? StatusTarefa);