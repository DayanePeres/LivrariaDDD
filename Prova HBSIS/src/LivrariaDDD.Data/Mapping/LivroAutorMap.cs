using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LivrariaDDD.Data.Mapping
{
    public class LivroAutorMap: IEntityTypeConfiguration<LivroAutorEntity>
    {
        public void Configure(EntityTypeBuilder<LivroAutorEntity> builder)
        {
            //Tabela de LivroAutor (n:n)
            builder.ToTable("LivroAutor");

            builder.HasKey(la => la.Id);
            builder.Property(la => la.Qtde)
                    .IsRequired();
            builder.HasOne(la => la.Livro)
                    .WithMany(al => al.ListLivroAutor)
                    .HasForeignKey(la => la.Id);

            builder.HasOne(la => la.Autor)
                .WithMany(al => al.ListLivroAutor)
                .HasForeignKey(la => la.Id);
        }
    }
}