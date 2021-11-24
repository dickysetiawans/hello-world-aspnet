using Microsoft.AspNetCore.Mvc;

namespace MvcBanking.Controllers
{
    public class ContactController:Controller
    {
        public IActionResult Index()
        {   
            ViewData["Message"]="Hello, This is my view";
            return View();
        }

        // public IActionResult Welcome()
        // {
        //     ViewData["Message"]="Hello, Welcome to HelloWorld Application";
        //     return View();
        // }
    }
}