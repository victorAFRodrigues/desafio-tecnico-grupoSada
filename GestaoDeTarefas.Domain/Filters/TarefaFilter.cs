using GestaoDeTarefas.Domain.Enums;

namespace GestaoDeTarefas.Domain.Filters;

public record TarefaFilter(
    DateTimeOffset? DataDe,
    DateTimeOffset? DataAte,
    StatusTarefa? StatusTarefa);