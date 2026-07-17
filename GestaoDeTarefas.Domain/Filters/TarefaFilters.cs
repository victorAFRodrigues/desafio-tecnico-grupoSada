using GestaoDeTarefas.Domain.Enums;

namespace GestaoDeTarefas.Domain.Filters;

public record TarefaFilters(
    DateTimeOffset? DataDe,
    DateTimeOffset? DataAte,
    StatusTarefa? Status);