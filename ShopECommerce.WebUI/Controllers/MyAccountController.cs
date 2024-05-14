﻿using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.WebUI.Models;
using System.Security.Claims;

namespace ShopECommerce.WebUI.Controllers
{
    public class MyAccountController : Controller
    {
        private readonly IUserService _userService;

        public MyAccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Detail()
        {
            var userEmailClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            if (userEmailClaim == null)
            {
                return NotFound();
            }

            var user = _userService.TGetByEmail(userEmailClaim);
            if (user == null)
            {
                return NotFound();
            }

            var detailUserViewModel = new DetailUserViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Phone = user.Phone,
                Address = user.Address
            };

            return View(detailUserViewModel);
        }


        [HttpGet]
        public IActionResult Update()
        {
            var userEmailClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            if (userEmailClaim == null)
            {
                return NotFound();
            }

            var user = _userService.TGetByEmail(userEmailClaim);
            if (user == null)
            {
                return NotFound();
            }

            UpdateUserViewModel updateUserViewModel = new UpdateUserViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Phone = user.Phone,
                Address = user.Address
            };

            return View(updateUserViewModel);
        }


        [HttpPost]
        public IActionResult Update(UpdateUserViewModel updateUserViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(updateUserViewModel);
            }

            var userEmailClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            if (userEmailClaim == null)
            {
                return NotFound();
            }

            var user = _userService.TGetByEmail(userEmailClaim);
            if (user == null)
            {
                return NotFound();
            }

            user.FirstName = updateUserViewModel.FirstName;
            user.LastName = updateUserViewModel.LastName;
            user.Username = updateUserViewModel.Username;
            user.Phone = updateUserViewModel.Phone;
            user.Address = updateUserViewModel.Address;

            _userService.TUpdate(user);
            return RedirectToAction("Index", "MyAccount");

        }
    }
}
