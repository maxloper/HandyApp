﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandyApp.Models;
using HandyApp.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace HandyApp.Controllers
{
    public class AccountController : Controller
    {


        // DI for user sign in and managment 
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }


        // register post

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel vm)
        {

            if (ModelState.IsValid)
            {

                var user = new ApplicationUser { UserName = vm.Email, Email = vm.Email };
                var result = await _userManager.CreateAsync(user, vm.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }


                }

            }

            return View(vm);

        }



        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        // login post

        [HttpPost]

        public async Task<IActionResult> Login(LoginVIewModel vm)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(vm.Email, vm.Password, vm.RememberMe,false);
                if (result.Succeeded)
                {
                    return RedirectToAction("index","Asign");
                }

                ModelState.AddModelError("","Invalid Login");
            }



            return View(vm);

        }   

    }
}
