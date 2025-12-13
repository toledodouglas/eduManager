using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EduManager.Domain.Interfaces; 
using EduManager.Infrastructure.Data;

namespace EduManager.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly EduContext _context;
        protected readonly DbSet<T> _dbSet;

        public Repository(EduContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddAsync(T entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
                await _context.SaveChangesAsync();
                return $"{entity} added successfully";

                Console.WriteLine($"[INFO] {typeof(T).Name} criado com sucesso.");
                return entity;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERRO] Falha ao criar {typeof(T).Name}: {ex.Message}");
                throw new Exception($"Erro ao criar entidade: {ex.Message}");
            }
        }
        

        public async Task UpdateAsync(T entity)
        {
            try
            {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();

            Console.WriteLine($"[INFO] {typeof(T).Name} atualizado com sucesso.")
            return $"{entity} updated successfully";

            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERRO] Falha ao atualizar {typeof(T).Name}: {ex.Message}");
                throw new Exception($"Erro ao atualizar entidade: {ex.Message}");
            }
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if(entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();

                Console.WriteLine($"[INFO] {typeof(T).Name} deletado com sucesso.");
                return entity;
            }

            Console.WriteLine($"[ERRO] {typeof(T).Name} com ID {id} não encontrado para deleção.");
            return null!;
        }
    }
}