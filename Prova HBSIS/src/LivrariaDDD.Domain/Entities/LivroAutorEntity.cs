using LivrariaDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class LivroAutorEntity : BaseEntity
    {
        public int Qtde { get; set; }
        public int codLivro { get; set; }
        public virtual LivroEntity Livro { get; set; }
        public int codAutor { get; set; }
        public virtual AutorEntity Autor { get; set; }
    }
}
