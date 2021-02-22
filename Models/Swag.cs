using winter20_burgershack.Interfaces;

namespace winter20_burgershack.Models
{
  public abstract class Swag : IPurchasable
  {
    public double Price { get; set; }
    public string Name { get; set; }
  }
}