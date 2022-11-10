using HotelApp.Data;
using HotelApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Controllers;

public class AdminController : Controller
{
    
    private readonly ApplicationDbContext _db;

    public AdminController(ApplicationDbContext db)
    {
        _db = db;
    }
    // GET
    public IActionResult Index()
    {
        
        return View();
    }

    public IActionResult Room()
    {
        IEnumerable<Room> objRoomList = _db.Rooms;
        return View(objRoomList);
    }
    
    public IActionResult CreateRoom()
    {
        return View();
    }
    //Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult CreateRoom(Room obj)
    {
        if (ModelState.IsValid)
        {
            _db.Rooms.Add(obj);
            _db.SaveChanges();
            TempData["success"] = "Customer added sucessfully ";
            return RedirectToAction("Room");
        }
        return View(obj);
    }
    
    public IActionResult EditRoom(int? id)
    {
          
        
        if (id == null || id ==0)
        {
            return NotFound();
        }

        
        var roomFromDb = _db.Rooms.Find(id);
        //var customerFromDbFirst = _db.Customers.FirstOrDefault(u=> u.CustomerId == Customerid);
        //var customerFromDbSingle = _db.Customers.SingleOrDefault(u=> u.CustomerId == customerid);

        if (roomFromDb == null)
        {
            return NotFound();
        }
        
        return View(roomFromDb);

    }
    //Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult EditRoom(Room obj)
    {
        if (ModelState.IsValid)
        {
            
            _db.Rooms.Update(obj);
            //_db.Entry(obj).State = EntityState.Modified;
            _db.SaveChanges();
            TempData["success"] = "Customer updated sucessfully ";
            return RedirectToAction("Room");
        }
        return View(obj);
    }
    //GET
    public IActionResult DeleteRoom(int? id)
    {
        if (id == null || id ==0)
        {
            return NotFound();
        }

        var roomFromDb = _db.Rooms.Find(id);
        // var customerFromDbFirst = _db.Customers.FirstOrDefault(u=> u.CustomerId == id);
        // var customerFromDbSingle = _db.Customers.SingleOrDefault(u=> u.CustomerId == id);

        if (roomFromDb == null)
        {
            return NotFound();
        }
        
        return View(roomFromDb);
        
    }
    
    //Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteRoomPost(int? RId)
    {
        var  obj = _db.Rooms.Find(RId);
        if (obj == null)
        {
            return NotFound();
        }
        _db.Rooms.Remove(obj);
        _db.SaveChanges();
        TempData["success"] = "Customer deleted sucessfully ";
        return RedirectToAction("Room");
        
    }
    
    public IActionResult Booking()
    {
        IEnumerable<Booking> objBookingList = _db.Bookings;
        return View(objBookingList);
    }
    
    public IActionResult CreateBooking()
    {
        return View();
    }
    //Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult CreateBooking(Booking obj)
    {
        if (ModelState.IsValid)
        {
            _db.Bookings.Add(obj);
            _db.SaveChanges();
            TempData["success"] = "Customer added sucessfully ";
            return RedirectToAction("Booking");
        }
        return View(obj);
    }
    
    public IActionResult EditBooking(int? id)
    {
          
        
        if (id == null || id ==0)
        {
            return NotFound();
        }

        
        var bookingFromDb = _db.Bookings.Find(id);
        //var customerFromDbFirst = _db.Customers.FirstOrDefault(u=> u.CustomerId == Customerid);
        //var customerFromDbSingle = _db.Customers.SingleOrDefault(u=> u.CustomerId == customerid);

        if (bookingFromDb == null)
        {
            return NotFound();
        }
        
        return View(bookingFromDb);

    }
    //Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult EditBooking(Booking obj)
    {
        if (ModelState.IsValid)
        {
            
            _db.Bookings.Update(obj);
            //_db.Entry(obj).State = EntityState.Modified;
            _db.SaveChanges();
            TempData["success"] = "Customer updated sucessfully ";
            return RedirectToAction("Booking");
        }
        return View(obj);
    }
    //GET
    public IActionResult DeleteBooking(int? id)
    {
        if (id == null || id ==0)
        {
            return NotFound();
        }

        var bookingFromDb = _db.Bookings.Find(id);
        // var customerFromDbFirst = _db.Customers.FirstOrDefault(u=> u.CustomerId == id);
        // var customerFromDbSingle = _db.Customers.SingleOrDefault(u=> u.CustomerId == id);

        if (bookingFromDb == null)
        {
            return NotFound();
        }
        
        return View(bookingFromDb);
        
    }
    
    //Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteBookingPost(int? BId)
    {
        var  obj = _db.Bookings.Find(BId);
        if (obj == null)
        {
            return NotFound();
        }
        _db.Bookings.Remove(obj);
        _db.SaveChanges();
        TempData["success"] = "Customer deleted sucessfully ";
        return RedirectToAction("Booking");
        
    }
    
    public IActionResult User()
    {
        IEnumerable<User> objUserList = _db.Users;
        return View(objUserList);
    }
    
    public IActionResult CreateUser()
    {
        return View();
    }
    //Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult CreateUser(User obj)
    {
        if (ModelState.IsValid)
        {
            _db.Users.Add(obj);
            _db.SaveChanges();
            TempData["success"] = "Customer added sucessfully ";
            return RedirectToAction("User");
        }
        return View(obj);
    }
    
    public IActionResult EditUser(int? id)
    {
          
        
        if (id == null || id ==0)
        {
            return NotFound();
        }

        
        var userFromDb = _db.Users.Find(id);
        //var customerFromDbFirst = _db.Customers.FirstOrDefault(u=> u.CustomerId == Customerid);
        //var customerFromDbSingle = _db.Customers.SingleOrDefault(u=> u.CustomerId == customerid);

        if (userFromDb == null)
        {
            return NotFound();
        }
        
        return View(userFromDb);

    }
    //Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult EditUser(User obj)
    {
        if (ModelState.IsValid)
        {
            _db.Users.Update(obj);
            //_db.Entry(obj).State = EntityState.Modified;
            _db.SaveChanges();
            TempData["success"] = "Customer updated sucessfully ";
            return RedirectToAction("User");
        }
        return View(obj);
    }
    //GET
    public IActionResult DeleteUser(int? id)
    {
        if (id == null || id ==0)
        {
            return NotFound();
        }

        var userFromDb = _db.Users.Find(id);
        // var customerFromDbFirst = _db.Customers.FirstOrDefault(u=> u.CustomerId == id);
        // var customerFromDbSingle = _db.Customers.SingleOrDefault(u=> u.CustomerId == id);

        if (userFromDb == null)
        {
            return NotFound();
        }
        
        return View(userFromDb);
        
    }
    
    //Post
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteUserPost(int? UserId)
    {
        var  obj = _db.Users.Find(UserId);
        if (obj == null)
        {
            return NotFound();
        }
        _db.Users.Remove(obj);
        _db.SaveChanges();
        TempData["success"] = "Customer deleted sucessfully ";
        return RedirectToAction("User");
        
    }
    
}