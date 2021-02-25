using Microsoft.EntityFrameworkCore;
using SundaySchoolManagement.Domain.DatabaseEntities;
//using System.Data.Entity;

namespace SundaySchoolManagement.Infrastructure
{
    public class SundaySchoolManagementContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public SundaySchoolManagementContext(DbContextOptions<SundaySchoolManagementContext> options) : base(options)
        {

        }
    }
}
