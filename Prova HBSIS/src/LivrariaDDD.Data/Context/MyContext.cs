using Domain.Entities;
using LivrariaDDD.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace LivrariaDDD.Data.Context
{
    public class MyContext : DbContext
    {
        //Classes 
        public DbSet<AutorEntity> Autores { get; set;}
        public DbSet<Editoraentity> Editoras { get; set; }
        public DbSet <LivroAutorEntity> LivroAutores { get; set; }
        public DbSet <LivroEditoraEntity> LivroEditoras { get; set; }
        public DbSet<LivroEntity> Livros { get; set; }

        //Configuração padrão     
        public MyContext(DbContextOptions<MyContext> options) : base (options){}

        protected override void OnModelCreating (ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AutorEntity> (new AutorMap().Configure);
            modelBuilder.Entity<Editoraentity> (new EditoraMap().Configure);
            modelBuilder.Entity<LivroAutorEntity> (new LivroAutorMap().Configure);
            modelBuilder.Entity<LivroEditoraEntity> (new LivroEditoraMap().Configure);
            modelBuilder.Entity<LivroEntity> (new LivroMap().Configure);
        }
    }
}