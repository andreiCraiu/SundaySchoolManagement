using SundaySchoolManagement.Domain.DatabaseEntities;
using System.Collections.Generic;

namespace SundaySchoolManagement.Application.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        User Insert(User user);
        User Update(User user);
        void Delete(int id);
    }
}
