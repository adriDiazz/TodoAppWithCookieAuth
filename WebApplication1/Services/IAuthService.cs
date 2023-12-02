using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models.DTOs;
using WebApplication1.Models.Entities;

namespace WebApplication1.Services
{
    internal interface IAuthService : IDisposable
    {

        void CreateUser(CreateUserDto user);
        //void DeleteUser(int userId);
        //void UpdateUser(User user);
        //User GetUser(int userId);
        User GetUserByEmail(string email);
        //List<User> GetUsers();
        void Login(LogInUserDto user);
        //void LogOut();
        //bool IsLoggedIn();
        //User GetCurrentUser();
        //bool IsAdmin();
        //bool IsUser();
    }
}
