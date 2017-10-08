﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OSL.MobileAppService.Models;
using OSL.MobileAppService.Services;

namespace OSL.MobileAppService.Controllers
{
    [Authorize(AuthenticationSchemes = "CookieScheme")]
    [Route("users")]
    public class UserWebController : Controller
    {
        private readonly UserRepository userRepository;

        public UserWebController(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View("Index", userRepository.Get());
        }

        [HttpGet("{id}/edit")]
        public IActionResult Edit(int id)
        {
            var user = userRepository.GetById(id);

            if (user != null)
            {
                return View("Edit", user);
            }

            return new NotFoundResult();
        }

        [HttpPost("{id}/edit")]
        public IActionResult Edit(int id, [FromForm]User value)
        {
            var user = userRepository.GetById(id);

            if (user != null)
            {
                userRepository.UpdateUser(id, value);
                return RedirectToAction("Edit", new { id });
            }

            return new NotFoundResult();
        }

        [HttpGet("{id}/deactivate")]
        public IActionResult Deactivate(int id)
        {
            var user = userRepository.GetById(id);

            if (user != null)
            {
                userRepository.DeactivateById(id);
                return RedirectToAction("Index");
            }

            return new NotFoundResult();
        }

        [HttpGet("{id}/activate")]
        public IActionResult Activate(int id)
        {
            var user = userRepository.GetById(id);

            if (user != null)
            {
                userRepository.ActivateById(id);
                return RedirectToAction("Index");
            }

            return new NotFoundResult();
        }
    }
}