using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LivrariaDDD.Data.Mapping
{
    public class EditoraMap: IEntityTypeConfiguration<Editoraentity>
    {
        public void Configure(EntityTypeBuilder<Editoraentity> builder)
        {
            //Tabela de EDITORA
            builder.ToTable("Editora");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100);
        }
    }
}