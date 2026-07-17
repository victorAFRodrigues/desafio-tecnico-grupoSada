using GestaoDeTarefas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoDeTarefas.Infrastructure.Data.Configurations;

public class TarefaConfiguration : IEntityTypeConfiguration<Tarefa>
{
    public void Configure(EntityTypeBuilder<Tarefa> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Titulo)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(t => t.Descricao)
            .HasMaxLength(2000);

        builder.Property(t => t.Status)
            .IsRequired();
    }
}