using Fake.DAL.Repository;
using Fake.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake.Business.Services
{
    public class UserService
    {
        UserRepository userRepository;
        public UserService()
        {
            userRepository= new UserRepository();            
        }
        public User GetUserByEmail(string email)
        { 
         return userRepository.GetUserByEmail(email);
        }
        public User GetUSerById(int id)
        {
            return userRepository.GetUserById(id);
        }
        public void AddUser(User user)
        { 
            userRepository.AddUser(user);            
        }
        public void UpdateUser(User user) 
        { 
            userRepository.UpdateUser(user);
        }
        public void DeleteUser(User user) 
        {
            userRepository.DeleteUser(user);
        }
        public bool UserLoginControl(string email, string password)
        { 
            return userRepository.UserLoginControl(email, password);
        }
        public bool UserForgotPasswordControl(string email, string phone)
        {
            if (userRepository.UserForgotPasswordControl(email,phone))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<User> GetExperts()
        {
            return userRepository.GetExperts();
        }
        public List<User> GetUsers()
        {
            return userRepository.GetUsers();
        }
    }
}
