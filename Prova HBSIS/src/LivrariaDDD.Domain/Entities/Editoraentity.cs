using LivrariaDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Editoraentity : BaseEntity
    {
        public string Nome { get; set; }
        public List<LivroEditoraEntity> ListLivroEditora { get; set; }
    }
}
