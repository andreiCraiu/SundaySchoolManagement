using SundaySchoolManagement.Domain.DatabaseEntities;
using SundaySchoolManagement.Infrastructure.Interfaces;
using System;


namespace SundaySchoolManagement.Infrastructure.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User GetByEmail(string email);
    }
}
