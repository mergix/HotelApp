using HotelApp.Data;
using HotelApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Controllers;

public class UserController : Controller
{

    private readonly ApplicationDbContext _db;

    public UserController(ApplicationDbContext db)
    {
        _db = db;
    }
    // GET
    public IActionResult Index()
    {
       IEnumerable<User> objCustomerList = _db.Users;
        return View(objCustomerList);
    }

    public IActionResult Login()
    {
        return View();
    }

    //GET
    public IActionResult Create()
    {
        return View();
    }
    
    //Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(User obj)
    {
        if (obj.UserName == obj.UserPassword)
        {
            ModelState.AddModelError("customername","Your Password cannot be the same as your name.");
        }
        if (ModelState.IsValid)
        {
            _db.Users.Add(obj);
            _db.SaveChanges();
            TempData["success"] = "Customer added sucessfully ";
            return RedirectToAction("Index");
        }
        return View(obj);
    }
    
    //GET
    public IActionResult Edit(int? id)
    {
        
        
        if (id == null || id ==0)
        {
            return NotFound();
        }

        
        var customerFromDb = _db.Users.Find(id);
        //var customerFromDbFirst = _db.Customers.FirstOrDefault(u=> u.CustomerId == Customerid);
        //var customerFromDbSingle = _db.Customers.SingleOrDefault(u=> u.CustomerId == customerid);

        if (customerFromDb == null)
        {
            return NotFound();
        }
        
        return View(customerFromDb);
        
    }
    
    //Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(User obj)
    {
        if (ModelState.IsValid)
        {
            
            _db.Users.Update(obj);
            //_db.Entry(obj).State = EntityState.Modified;
            _db.SaveChanges();
            TempData["success"] = "Customer updated sucessfully ";
            return RedirectToAction("Index");
        }
        return View(obj);
    }
    
    //GET
    public IActionResult Delete(int? id)
    {
        if (id == null || id ==0)
        {
            return NotFound();
        }

        var customerFromDb = _db.Users.Find(id);
        // var customerFromDbFirst = _db.Customers.FirstOrDefault(u=> u.CustomerId == id);
        // var customerFromDbSingle = _db.Customers.SingleOrDefault(u=> u.CustomerId == id);

        if (customerFromDb == null)
        {
            return NotFound();
        }
        
        return View(customerFromDb);
        
    }
    
    //Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult DeletePost(int? UserId)
    {
        var  obj = _db.Users.Find(UserId);
        if (obj == null)
        {
            return NotFound();
        }
        _db.Users.Remove(obj);
        _db.SaveChanges();
        TempData["success"] = "Customer deleted sucessfully ";
        return RedirectToAction("Index");
        
    }
}