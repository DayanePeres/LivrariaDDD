using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LivrariaDDD.Data.Mapping
{
    public class LivroMap : IEntityTypeConfiguration<LivroEntity>
    {
        public void Configure(EntityTypeBuilder<LivroEntity> builder)
        {
            //criando a tabela de LIVROS
            builder.ToTable("Livro");

            builder.HasKey(l => l.Id);
            builder.Property(l => l.Titulo)
                    .IsRequired()
                    .HasMaxLength(100);
            builder.Property(l => l.AnoEdicao);
            builder.Property(l => l.Genero)
                    .HasMaxLength(50);            
        }
        
    }
}