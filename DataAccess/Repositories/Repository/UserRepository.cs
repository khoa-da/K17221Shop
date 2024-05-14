using BusinessObject.DTO;
using BusinessObject.Models;
using DataAccess.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Repository
{
    public class UserRepository : IUserRepository
    {
/*        public void AddNew(User user) => UserDAO.Instance.AddNew(user);*/

        public User checkLogin(string userEmail, string password) => UserDAO.Instance.checkLogin(userEmail, password);


        /*public void Delete(int id) => UserDAO.Instance.Delete(id);


        public List<UserDTO> GetAllUsers() => UserDAO.Instance.GetAllUsers();

        public User GetUserByEmail(string email) => UserDAO.Instance.GetUserByEmail(email);


        public User GetUserByID(int id) => UserDAO.Instance.GetUserByID(id);


        public UserDTO GetUserDTOById(int id) => UserDAO.Instance.GetUserDTOByID(id);


        public void Update(User user) => UserDAO.Instance.Update(user);*/

    }
}
