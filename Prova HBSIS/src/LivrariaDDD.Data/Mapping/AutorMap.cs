using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LivrariaDDD.Data.Mapping
{
    public class AutorMap : IEntityTypeConfiguration<AutorEntity>
    {
        public void Configure (EntityTypeBuilder<AutorEntity> builder)
        {        
            //Tabela de AUTOR
            builder.ToTable("Autor");

            builder.HasKey(a => a.Id);
            builder.Property(a => a.Nome)
                    .IsRequired()
                    .HasMaxLength(100);

        }
    }
}