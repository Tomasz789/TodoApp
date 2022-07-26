using Microsoft.AspNetCore.Mvc;

namespace ToDoList.WebApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

    }
}
