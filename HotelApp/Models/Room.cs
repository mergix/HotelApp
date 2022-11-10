namespace HotelApp.Models;
using System.ComponentModel.DataAnnotations;

public class Room
{
    [Key]
    public int RId { get; set; }
    [Required]
    public string? RName { get; set; }
    public int? RCost { get; set; }
    
    public string? RComment { get; set; }
    
    public Boolean? RStatus { get; set; }
    
}