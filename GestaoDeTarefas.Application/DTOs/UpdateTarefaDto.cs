using GestaoDeTarefas.Domain.Enums;

namespace GestaoDeTarefas.Application.DTOs;

public record UpdateTarefaDto(Guid Id, string? Titulo, string? Descricao, DateTimeOffset? DataDeVencimento, StatusTarefa? StatusTarefa);