using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EduManager.Domain.Entities;
using EduManager.Domain.Interfaces;
using EduManager.Infrastructure.Data;

namespace EduManager.Infrastructure.Repositories
{
    public class DirectorRepository : Repository<Director>, IDirectorRepository
    {
        public DirectorRepository(EduContext context) : base(context)
        {
        }

        public async Task<Director?> GetByDepartmentAsync(string department)
        {
            return await _dbSet
                .AsNoTracking()
                .FirstOrDefaultAsync(d => d.Department == department);
        }
    }
}