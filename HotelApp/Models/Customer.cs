using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models;

public class Customer
{
    [Key]
    public int CustomerId { get; set; }
    [Required]
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public string CustomerAddress { get; set; }
    public string CustomerPassword  { get; set; } //read about how to hash this 
    public DateTime DateJoined { get; set; } = DateTime.Now;
}