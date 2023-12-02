using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models.DTOs;
using WebApplication1.Models.Entities;

namespace WebApplication1.Repositories
{
    internal interface IAuthRepository: IDisposable
    {
        void CreateUser(User user);
        void DeleteUser(int userId);
        void UpdateUser(User user);
        User GetUser(int userId);
        User GetUserByEmail(string email);
        List<User> GetUsers();


            
    }
}
