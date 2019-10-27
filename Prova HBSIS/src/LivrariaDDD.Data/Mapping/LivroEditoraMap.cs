using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LivrariaDDD.Data.Mapping
{
    public class LivroEditoraMap : IEntityTypeConfiguration<LivroEditoraEntity>
    {        
        public void Configure(EntityTypeBuilder<LivroEditoraEntity> builder)
        {
            //Tabela de LivroEditora
            builder.ToTable("LivroEditora");

            builder.HasKey(le => le.Id);
            builder.Property(le => le.Qtde)
                    .IsRequired();

            builder.HasOne(la => la.Livro)
                    .WithMany(al => al.ListLivroEditora)
                    .HasForeignKey(la => la.Id);

            builder.HasOne(la => la.Editora)
            .WithMany(al => al.ListLivroEditora)
            .HasForeignKey(la => la.Id);
        }
        
    }
}