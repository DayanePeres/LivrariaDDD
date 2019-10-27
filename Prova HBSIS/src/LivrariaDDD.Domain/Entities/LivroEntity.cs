using LivrariaDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class LivroEntity : BaseEntity
    {
        public string Titulo { get; set; }
        public System.DateTime AnoEdicao { get; set; }
        public string Genero { get; set; }

        public List<LivroAutorEntity> ListLivroAutor { get; set; }
        public List<LivroEditoraEntity> ListLivroEditora { get; set; }
    }
}
