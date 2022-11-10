namespace HotelApp.Models;
using System.ComponentModel.DataAnnotations;

public class Admin
{
    [Key]
    public int AdminId { get; set; }
    [Required]
    public string? AdminName { get; set; }
    [Required]
    public string? AdminEmail { get; set; }
    
    public int? AdminAddress { get; set; }
    
    public string? AdminGender { get; set; }
    [Required]
    public string? AdminPassword  { get; set; } //read about how to hash this 
    public DateTime? DateAdded { get; set; } = DateTime.UtcNow;
}