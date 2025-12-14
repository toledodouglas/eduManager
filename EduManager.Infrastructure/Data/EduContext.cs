using EduManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EduManager.Infrastructure.Data
{
    public class EduContext : DbContext
    {
        public EduContext(DbContextOptions<EduContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Director> Directors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasDiscriminator<string>("PersonType")
                .HasValue<Student>("Student")
                .HasValue<Teacher>("Teacher")
                .HasValue<Director>("Director");
        }
    }
}