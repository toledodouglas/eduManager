using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EduManager.Domain.Entities;
using EduManager.Domain.Interfaces;
using EduManager.Infrastructure.Data;

namespace EduManager.Infrastructure.Repositories
{
    public class TeacherRepository : Repository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(EduContext context) : base(context)
        {
        }

        public async Task<Teacher?> GetByEmailAsync(string email)
        {
            return await _dbSet
                .AsNoTracking()
                .Include(t => t.Students)
                .FirstOrDefaultAsync(t => t.Email == email);
        }
    }
}