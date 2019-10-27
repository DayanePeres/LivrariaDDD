using LivrariaDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class AutorEntity : BaseEntity
    {
        public string Nome { get; set; }
        public List<LivroAutorEntity> ListLivroAutor { get; set; }
    }
}
