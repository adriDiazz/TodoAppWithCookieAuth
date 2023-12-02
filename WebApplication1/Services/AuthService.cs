using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using WebApplication1.Models.DTOs;
using WebApplication1.Models.Entities;
using WebApplication1.Repositories;
using WebApplication1.Utils;

namespace WebApplication1.Services
{
    public class AuthService : IAuthService, IDisposable
    {
        IAuthRepository _authRepository;

        public AuthService()
        {
            _authRepository = new AuthRepository();
        }

        public void CreateUser(CreateUserDto userDto)
        {
            if(userDto.Password != userDto.ConfirmPassword)
            {
                throw new Exception("Passwords do not match");
            }

            string hashedPassword = HashHeper.Hash(userDto.Password);

            User user = new User()
            {
                Name = userDto.Name,
                Email = userDto.Email,
                Password = hashedPassword,
                RolId = Rol.USER
            };

            _authRepository.CreateUser(user);
        }

        public User GetUserByEmail(string email)
        {
            return _authRepository.GetUserByEmail(email);
        }

        public void Login(LogInUserDto loginDto)
        {
            User user = GetUserByEmail(loginDto.Email);

            if (user == null)
            {
                throw new Exception("User not found");
            }

            if (!HashHeper.Verify(loginDto.Password, user.Password))
            {
                throw new Exception("Invalid password");
            }

            FormsAuthentication.SetAuthCookie(user.Email, false);

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_authRepository != null)
                {
                    _authRepository.Dispose();
                    _authRepository = null;
                }
            }
        }



    }
}