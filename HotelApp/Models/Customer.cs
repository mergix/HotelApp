using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models;

public class Customer
{
    [Key]
    public int CustomerId { get; set; }
    [Required]
    public string? CustomerName { get; set; }
    public string? CustomerEmail { get; set; }
    public string? CustomerAddress { get; set; }
    [DisplayName("Password")]
    // [Range(1,5,ErrorMessage = "Password must be between 1 to 5 only!")]
    public string? CustomerPassword  { get; set; } //read about how to hash this 
    //public DateTime DateJoined { get; set; } = DateTime.UtcNow;
}