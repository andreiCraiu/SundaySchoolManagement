using SundaySchoolManagement.Domain.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SundaySchoolManagement.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(SundaySchoolManagementContext context) : base(context)
        {
        }

        // read from DB
        public User GetByEmail(string email)
        {
            return _table.SingleOrDefault(user => user.Email == email);
        }
    }
}
