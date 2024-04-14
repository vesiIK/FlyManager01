using FlyManager01.Models;
using FlyManager01.ViewModals;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FlyManager01.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<AccountsUser> signInManager;
        private readonly UserManager<AccountsUser> userManager;

       
        public AccountController(SignInManager<AccountsUser> signInManager, UserManager<AccountsUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                //login
                var result = await signInManager.PasswordSignInAsync(model.UserName!, model.Password!, model.RememberMe!, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Invalid log in attempt");
                return View(model);
            }
            return View(model);
        }

        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Registration(RegistrtionVM model)
        {
            if (ModelState.IsValid)
            {
                AccountsUser user = new()
                {
                    FName = model.FirstName,
                    LName = model.LastName,
                    NickName = model.NickName,
                    Email = model.Email,
                    Adress = model.Adress,
                    EGN = model.EGN,
                    Role = "",
                    UserName=model.NickName,
                    PhoneNumber=model.PhoneNumber
                };
                var result = await userManager.CreateAsync(user, model.Password); 
                if(result.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

           
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        //НЕ РАБОТИ
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPassword([Required] string email)
        {
            if (!ModelState.IsValid)
                return View(email);

            var user = await userManager.FindByEmailAsync(email);
            if (user == null)
                return RedirectToAction(nameof(ForgotPasswordConfirmation));

            var token = await userManager.GeneratePasswordResetTokenAsync(user);
            var link = Url.Action("ResetPassword", "Account", new { token, email = user.Email }, Request.Scheme);

            EmailHelper emailHelper = new EmailHelper();
            bool emailResponse = emailHelper.SendEmailPasswordReset(user.Email, link);

            if (emailResponse)
                return RedirectToAction("ForgotPasswordConfirmation");
            else
            {
                // log email failed 
            }
            return View(email);
        }

        [AllowAnonymous]
        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }
    }
}
