using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models;

public class User
{
    [Key]
    public int UserId { get; set; }
    [Required]
    public string? UserName { get; set; }
    [Required]
    public string? UserEmail { get; set; }
    [Required]
    public string? UserGender { get; set; }
    [Required]
    public string? UserAddress { get; set; }
    [Required]
    public string? UserPassword  { get; set; } //read about how to hash this 
    public DateTime? DateJoined { get; set; } = DateTime.UtcNow;
}