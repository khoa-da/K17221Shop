using BusinessObject.DTO;
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserDAO
    {
        private static UserDAO instance = null;

        public static readonly object instanceLock = new object();
        private readonly K17221shopContext _context;

        public UserDAO()
        {
            _context = new K17221shopContext();
        }

        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }

        public User checkLogin(string userEmail, string password)
        {
            try
            {
                var check = _context.Users.Where(u => u.UserEmail!.Equals(userEmail) && u.UserPassword!.Equals(password)).FirstOrDefault();

                if (check != null)
                {
                    return check;
                }
                throw new Exception();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /*public List<UserDTO> GetAllUsers()
        {
            var users = _context.Users
                .Include(t => t.UserRole).ToList();

            List<UserDTO> userList = new List<UserDTO>();
            foreach (var user in users)
            {
                var _user = new UserDTO()
                {
                    UserId = user.UserId,
                    UserName = user.UserName,
                    UserEmail = user.UserEmail,
                    UserRoleId = user.UserRoleId,
                    Status = user.Status,
                    UserPassword = user.UserPassword
                };

                userList.Add(_user);
            }

            return userList;
        }
        public User GetUserByEmail(string email)
        {
            try
            {
                return _context.Users.Where(u => u.UserEmail.Equals(email)).SingleOrDefault()!;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public UserDTO GetUserDTOByID(int id)
        {
            try
            {
                return GetAllUsers().Where(u => u.UserId.Equals(id)).FirstOrDefault()!;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public User GetUserByID(int id)
        {
            try
            {
                return _context.Users
                .Include(t => t.UserId).Where(t => t.UserId == id).FirstOrDefault()!;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void AddNew(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(User user)
        {
            try
            {
                var _user = _context.Users.Where(u => u.UserId == user.UserId).FirstOrDefault();
                if (_user != null)
                {
                    _user.UserId = user.UserId;
                    _user.UserName = user.UserName;
                    _user.UserEmail = user.UserEmail;
                    _user.Status = user.Status;
                    _context.Update(_user);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                var check = TblUserExists(id);
                if (check)
                {
                    _context.Remove(check);
                    _context.SaveChanges();
                }
                throw new Exception("User not exist");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        private bool TblUserExists(int id)
        {
            return (_context.Users?.Any(e => e.UserId == id)).GetValueOrDefault();
        }*/
    }
}
