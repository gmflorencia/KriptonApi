using KriptonApi.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KriptonApi.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }
        public virtual async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }
        public virtual async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
    }

}
