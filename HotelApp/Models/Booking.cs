using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Models;
using System.ComponentModel.DataAnnotations;

public class Booking
{
    [Key]
    public int BId { get; set; }
    
    public int Amount { get; set; }
    
    [ForeignKey("User")]
    public int UserId { get; set; }
    
    public DateTime BDate { get; set; } = DateTime.UtcNow;
    [ForeignKey("Room")]
    public int RId  { get; set; } 
    
    public DateTime DateIn { get; set; }
    
    public DateTime DateOut { get; set; }
    
    
    
}