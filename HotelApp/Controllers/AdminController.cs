using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Controllers;

public class AdminController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}