using System.ComponentModel.DataAnnotations;
using winter20_burgershack.Interfaces;

namespace burgershack_winter20.Models
{
  public abstract class MenuItem : IPurchasable
  {
    public int Id { get; set; }
    [Required]
    [Range(1, 1000)]
    public double Price { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public int CalMin { get; set; }
    [Required]
    public int CalMax { get; set; }
    public string Category { get; set; }
  }
}