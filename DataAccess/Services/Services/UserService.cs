using BusinessObject.DTO;
using BusinessObject.Models;
using DataAccess.Repositories.IRepository;
using DataAccess.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
/*        public void AddNew(User user) => _userRepository.AddNew(user);*/


        public User checkLogin(string userEmail, string password) => _userRepository.checkLogin(userEmail, password);
/*
        public void Delete(int id) => _userRepository.Delete(id);

        public List<UserDTO> GetAllUsers() => _userRepository.GetAllUsers();

        public User GetUserByEmail(string email) => _userRepository.GetUserByEmail(email);

        public User GetUserByID(int id) => _userRepository.GetUserByID(id);

        public UserDTO GetUserDTOById(int id) => _userRepository.GetUserDTOById(id);

        public void Update(User user) => _userRepository.Update(user);*/

    }
}
