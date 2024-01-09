using LeetcodeUserInfo.Models;
using LeetcodeUserInfo.Models.GraphQL;
using LeetcodeUserInfo.Models.Leetcode;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LeetcodeUserInfo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private GraphQLProvider provider = new GraphQLProvider();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()=> View();
        [HttpGet]
        public IActionResult UsersNotFound() => View();
        [HttpGet]
        public IActionResult UserNotValidation() => View();
        [HttpPost]
        public async Task<IActionResult> LeetCodeView(string username)
        {
            if(username?.Length > 2)
            {
                UserProfileData user = provider.GetUserInfo(username);
                if(user.MatchedUser == null)
                    return RedirectToAction("UsersNotFound");
                else
                    return View(user);
            }
            else
                return RedirectToAction("UserNotValidation");

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
