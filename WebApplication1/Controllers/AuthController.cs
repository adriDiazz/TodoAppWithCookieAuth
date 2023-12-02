using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication1.Models.DTOs;
using WebApplication1.Models.Entities;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class AuthController : Controller
    {

        private readonly IAuthService authService;

        public AuthController()
        {
            authService = new AuthService();
        }

        // GET: Auth
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LogInUserDto userDto, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                authService.Login(userDto);

                if(ReturnUrl != null)
                {
                    Redirect(ReturnUrl);
                }

                return RedirectToAction("Index", "Todo");

            }

            return View(userDto);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(CreateUserDto userDto)
        {
            if (ModelState.IsValid)
            {
                authService.CreateUser(userDto);
                return RedirectToAction("Index", "Todo");
            }

            return View(userDto);
        }

    }
}