using HotelApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Customer> Customers { get; set; }
}