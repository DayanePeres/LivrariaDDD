using LivrariaDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class LivroEditoraEntity : BaseEntity
    {
        public int Qtde { get; set; }
        public int codEditora { get; set; }
        public virtual Editoraentity Editora { get; set; }
        public int codLivro { get; set; }
        public virtual LivroEntity Livro { get; set; }
    }
}
