using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace LivrariaDDD.Domain.Interfaces.Services.Livros
{
    public interface ILivroService
    {
        //service para um livro
         Task<LivroEntity> Get (Guid id);
         Task<IEnumerable<LivroEntity>> GetAll ();
         Task<LivroEntity> Post (LivroEntity livroEntity);
         Task<LivroEntity> Put (LivroEntity livroEntity); //atualização
         Task<bool> Delete (Guid id);
    }
}