using Hackathon_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hackathon_API.Data.Mappings
{
    public class ConcursoMap : IEntityTypeConfiguration<Concurso>
    {
        public void Configure(EntityTypeBuilder<Concurso> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Nome)
                .IsRequired();

            builder.Property(x => x.NumeroVagas)
                .IsRequired();

            builder.Property(x => x.DataConcurso)
                .IsRequired();
        }
    }
}
