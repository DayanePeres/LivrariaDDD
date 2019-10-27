using System;
using System.ComponentModel.DataAnnotations;

namespace LivrariaDDD.Domain.Entities
{// Classe base para as demais classes 

    public abstract class BaseEntity
    {

        [Key] // identificar chave primária
        public Guid Id { get; set; }

        private DateTime? _createAt;

        public DateTime? CreateAt {
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }    
        public DateTime? UpdateAt { get; set; }
    }
}