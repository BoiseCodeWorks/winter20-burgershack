using System;
using System.ComponentModel.DataAnnotations;

namespace burgershack_winter20.Models
{
  public class Drink : MenuItem
  {
    public string Size { get; set; }
    public bool SugarFree { get; set; }

    public Drink()
    {
      Category = "Drink";
    }

  }

}

