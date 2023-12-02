using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Data;
using WebApplication1.Models.DTOs;
using WebApplication1.Models.Entities;

namespace WebApplication1.Repositories
{
    public class AuthRepository: IAuthRepository, IDisposable
    {

        private readonly TodoContext context = new TodoContext();


        public void CreateUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public void DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int userId)
        {
            throw new NotImplementedException();
        }

        public User GetUserByEmail(string email)
        {
            return context.Users.Where(u => u.Email == email).FirstOrDefault();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
    
    }
