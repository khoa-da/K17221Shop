using BusinessObject.DTO;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.IRepository
{
    public interface IUserRepository
    {
/*        List<UserDTO> GetAllUsers();

        UserDTO GetUserDTOById(int id);
        User GetUserByEmail(string email);
        User GetUserByID(int id);

        void AddNew(User user);

        void Update(User user);

        void Delete(int id);*/

        User checkLogin(string userEmail, string password);
    }
}
