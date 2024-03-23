using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Snappass.Models;
using System.Collections.Generic;

namespace Snappass.Controllers
{
    public class UserController : Controller
    {
        private readonly IMemoryStore _memoryStore;
        private readonly ILogger<PasswordController> _logger;

        public UserController(IMemoryStore memoryStore, ILogger<PasswordController> logger)
        {
            _memoryStore = memoryStore;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get(string userId)
        {
            return Json(
                new UserModel
                {
                    UserId = userId,
                    Secrets = new List<GeneratedPassword>() {
                        new GeneratedPassword { Key = "one", BaseUri = "asdfasdf" },
                        new GeneratedPassword { Key = "two", BaseUri = "asdfasdfasdasdfasd" }
                    }
                });
        }
    }
}