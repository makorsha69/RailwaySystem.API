using RailwaySystem.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RailwaySystem.API.Repository;

namespace RailwaySystem.API.Service
{
    public class UserServices
    {
       private IUserRepo _userRepository;
        public UserServices(IUserRepo userRepository)
        {
            _userRepository = userRepository;
        }
        public string SaveUser(User user)
        {
            return _userRepository.SaveUser(user);
        }
        public string UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }
        public User GetUser(int UserId)
        {
            return _userRepository.GetUser(UserId);
        }
        public List<User> GetAllUser()
        {
            return _userRepository.GetAllUser();
        }
    }
}
