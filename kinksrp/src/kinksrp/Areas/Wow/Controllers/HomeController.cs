using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using kinksrp.Areas.Wow.Models.ViewModel;
using kinksrp.Areas.Wow.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace kinksrp.Controllers
{

    [Area("Wow")]
    public class HomeController : Controller
    {
        private IUserRepository userRepository;

        public HomeController(IUserRepository userRepo)
        {
            userRepository = userRepo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            foreach (User user in userRepository.Users)
            {
                user.Reputation++;
                
            }
            userRepository.SaveChanges();
            return View(new WowViewModel
            {
                Users = userRepository.Users,
            });
        }
    }
}
