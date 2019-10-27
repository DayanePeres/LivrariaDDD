using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using LivrariaDDD.Domain.Entities;

namespace LivrariaDDD.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        //crud da entidade assinatura para as demais
        Task<T> InsertAsync(T item); // Método assíncrono, pode executar vários de uma vez
        Task<T> UpdateAsync(T item);
        Task<bool> DeleteAsync(Guid id);
        Task<T> SelectAsync(Guid id);
        Task <IEnumerable<T>> SelectAsync(); // poder ser utilizado List ao invés de Enumerable, porém é melhor em performace
        Task<bool> ExistAsync(Guid id);
       
    }
}