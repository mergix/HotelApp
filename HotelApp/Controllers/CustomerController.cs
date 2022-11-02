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

    //GET
    public IActionResult Create()
    {
        return View();
    }
    
    //Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Customer obj)
    {
        if (obj.CustomerName == obj.CustomerPassword.ToString())
        {
            ModelState.AddModelError("customername","Your Password cannot be the same as your name.");
        }
        if (ModelState.IsValid)
        {
            _db.Customers.Add(obj);
            _db.SaveChanges();
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

        
        var customerFromDb = _db.Customers.Find(id);
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
    public IActionResult Edit(Customer obj)
    {
        // if (obj.CustomerName == obj.CustomerPassword)
        // {
        //     ModelState.AddModelError("customername","Your Password cannot be the same as your name.");
        // }
        if (ModelState.IsValid)
        {
            _db.Customers.Update(obj);
            _db.SaveChanges();
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

        var customerFromDb = _db.Customers.Find(id);
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
    public IActionResult DeletePost(int? id)
    {
        var obj = _db.Customers.Find(id);
        if (obj == null)
        {
            return NotFound();
        }
       
            _db.Customers.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        
    }
}