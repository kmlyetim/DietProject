using Fake.DAL.Context;
using Fake.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake.DAL.Repository
{
    public class UserRepository
    {
        FakeContext db;

        public UserRepository()
        {
            db= new FakeContext();

        }
        public User GetUserByEmail(string email)
        {
            return db.Users.Where(x=> x.Email == email).FirstOrDefault();
        }
        public User GetUserById(int id)
        {            
            return db.Users.Find(id);
        }
        public void AddUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }
        public void UpdateUser(User updatedUserInfo)
        {
            User willBeUpdated = GetUserById(updatedUserInfo.Id);
            db.Entry(willBeUpdated).CurrentValues.SetValues(updatedUserInfo);            
            db.SaveChanges();
        }
        public void DeleteUser(User user)
        { 
            User willBeRemovedUser = GetUserById(user.Id);
            db.Users.Remove(willBeRemovedUser);
            db.SaveChanges();        
        }

        public bool UserLoginControl(string email, string password)
        {
            var mailControl= db.Users.Where(x=> x.Email==email).ToList();
            var passControl = db.Users.Where(x => x.Password == password && x.Email == email).ToList();
            if (mailControl.Count()==0)
            {
                throw new Exception("Email does not exist");                
            }
            else if (passControl.Count()==0)
            {
                throw new Exception("Password is not correct");                
            }
            else
            {
                return true;
            }
        }
        public bool UserForgotPasswordControl(string email,string phone)
        {
            if (db.Users.Any(x => x.Email == email && x.PhoneNumber == phone))
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
            return db.Users.Where(x=>x.UserStatus==Enums.UserStatus.Expert).ToList();
        }
        public List<User> GetUsers()
        {
            return db.Users.Where(x => x.UserStatus == Enums.UserStatus.User).ToList();
        }
    }
}
