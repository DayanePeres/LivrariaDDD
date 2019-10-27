using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using LivrariaDDD.Data.Context;
using LivrariaDDD.Domain.Entities;
using LivrariaDDD.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LivrariaDDD.Data.Repository
{
    public class BaseRepository <T> : IRepository<T> where T : BaseEntity
    {
        protected readonly MyContext _context;
        private DbSet<T> _dataSet;

        //Construtor
        public BaseRepository(MyContext context) //Recebe injeção de dependência do Context
        {
            _context = context; // disponibiliza para a classe como um todo
            _dataSet = _context.Set<T>();
        }
        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                //faz a pesquisa no banco
                var result = await _dataSet.SingleOrDefaultAsync(p => p.Id.Equals(id));
                //verificar se não é nulo, caso seja retorna false, pois não encontrou 
                if (result == null)
                    return false;

                //faz o delete
                _dataSet.Remove(result);
                //e salva a operação
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> InsertAsync(T item)
        {
            try
            {
                if(item.Id == Guid.Empty)
                {
                    item.Id = Guid.NewGuid(); // Recebe um novo ID (Guid não deixa duplicar id)
                }
                item.CreateAt = DateTime.UtcNow;
                _dataSet.Add(item);
                await _context.SaveChangesAsync(); //faz commit o banco, caso erro da rollback
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;
        }

        public async Task<T> SelectAsync(Guid id)
        {
            try
            {
                return await _dataSet.SingleOrDefaultAsync(p => p.Id.Equals(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       public async Task<IEnumerable<T>> SelectAsync()
        {
            try
            {
                return await _dataSet.ToListAsync(); //select sem where
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //metódos tem que estar com a assinatura na interface
        public async Task<bool> ExistAsync(Guid id)
        {
            return await _dataSet.AnyAsync(p => p.Id.Equals(id));
        }

        public async Task<T> UpdateAsync(T item)
        {
            try
            {
                //verifica se existe o registro azendo o select e depois faz o update
                var result = await _dataSet.SingleOrDefaultAsync(p => p.Id.Equals(item.Id));
                if (result == null)
                    return null;

                item.UpdateAt = DateTime.UtcNow;
                item.CreateAt = result.CreateAt;
                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync(); // faz commit ou roolback
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;
        }

    }
}