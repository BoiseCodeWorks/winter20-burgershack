using System;
using System.ComponentModel.DataAnnotations;

namespace burgershack_winter20.Models
{
  public class Side : MenuItem
  {
    public string Size { get; set; }
    public Side()
    {
      Category = "Side";
    }

  }

}
