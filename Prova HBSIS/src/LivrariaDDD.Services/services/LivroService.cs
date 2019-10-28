using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using LivrariaDDD.Domain.Interfaces;
using LivrariaDDD.Domain.Interfaces.Services.Livros;
using System.Linq;

namespace LivrariaDDD.Services.services
{
    public class LivroService : ILivroService
    {
        private IRepository <LivroEntity> _repository;

        public LivroService (IRepository<LivroEntity> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete (Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<LivroEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<LivroEntity>> GetAll()
        {
            var result = await _repository.SelectAsync();
            return result.OrderBy(x => x.Titulo);
        }

        public async Task<LivroEntity> Post(LivroEntity livroEntity)
        {
            //colocar verificações
            return await _repository.InsertAsync(livroEntity);
        }

        public async Task<LivroEntity> Put(LivroEntity livroEntity)
        {
            return await _repository.UpdateAsync(livroEntity);
        }
    }
}
