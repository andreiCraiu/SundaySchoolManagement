using SundaySchoolManagement.Application.Interfaces;
using SundaySchoolManagement.Domain.DatabaseEntities;
using SundaySchoolManagement.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace SundaySchoolManagement.Application
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public User Insert(User user)
        {
            return _userRepository.Insert(user);
        }

        public User Update(User user)
        {
            user.Password = _userRepository.GetById(user.Id).Password;
            return _userRepository.Update(user);
        }
    }
}
