using HotelApp.Data;
using HotelApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Controllers;

public class CustomerController : Controller
{

    private readonly ApplicationDbContext _db;

    public CustomerController(ApplicationDbContext db)
    {
        _db = db;
    }
    // GET
    public IActionResult Index()
    {
       IEnumerable<Customer> objCustomerList = _db.Customers;
        return View(objCustomerList);
    }

    public IActionResult Create()
    {
        return View();
    }
}