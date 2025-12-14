using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EduManager.Domain.Entities;
using EduManager.Domain.Interfaces;
using EduManager.Infrastructure.Data;

namespace EduManager.Infrastructure.Repositories
{
    public class StudentRepository : Repository<Student> , IStudentRepository
    {
        public StudentRepository(EduContext context) : base(context)
        {
        }

        public async Task<Student?> GetByRegistrationAsync(string registration)
        {
            return await _dbSet
                .AsNoTracking()
                .Include(s => s.Teachers)
                .FirstOrDefaultAsync(s => s.Registration == registration);
        }
    }
}