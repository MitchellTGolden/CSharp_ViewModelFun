using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("users")]
        public IActionResult Users()
        {
            // to a View that has defined a model as @model string[]
            User moose = new User()
            {
                FirstName = "Moose",
                LastName = "Phillips"
            };
            User sarah = new User()
            {
                FirstName = "Sarah",
                LastName = ""
            };
            User jerry = new User()
            {
                FirstName = "Jerry",
                LastName = ""
            };
            User Rene = new User()
            {
                FirstName = "Rene",
                LastName = "Ricky"
            };
            User barbarah = new User()
            {
                FirstName = "Barbarah",
                LastName = ""
            };
            List<User> userList = new List<User>()
            {
            moose, sarah, jerry, Rene, barbarah
            };
            return View(userList);
            
        }

        [HttpGet("user")]
        public IActionResult OneUser()
        {
            Random rand = new Random();
            // to a View that has defined a model as @model string[]
            User moose = new User()
            {
                FirstName = "Moose",
                LastName = "Phillips"
            };
            User sarah = new User()
            {
                FirstName = "Sarah",
            };
            User jerry = new User()
            {
                FirstName = "Jerry",
            };
            User Rene = new User()
            {
                FirstName = "Rene",
                LastName = "Ricky"
            };
            User barbarah = new User()
            {
                FirstName = "Barbarah",
            };
            List<User> userList = new List<User>()
            {
            moose, sarah, jerry, Rene, barbarah
            };
            var OneUser = userList[rand.Next(0, userList.Count)];

            return View(OneUser);
        }
        public IActionResult Index()
        {
            // to a View that has defined a model as @model string[]
            string message = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Maiores molestiae voluptatibus veritatis ratione sapiente. Quam nostrum similique minus ipsa saepe eligendi, blanditiis dolor reiciendis iste vero nisi nam, delectus unde?";

            return View(model: message);
        }
        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[]
            {
            1,4,3,10,43,5
            };
            return View(model: numbers);
        }
    }
}
