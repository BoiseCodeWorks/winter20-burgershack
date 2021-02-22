using System;
using System.Collections.Generic;
using burgershack_winter20.Models;
using burgershack_winter20.Repositories;

namespace burgershack_winter20.Services
{
  public class DrinkService
  {

    private readonly DrinkRepository _repo;

    public DrinkService(DrinkRepository repo)
    {
      _repo = repo;
    }

    internal IEnumerable<Drink> Get()
    {
      return _repo.GetAll();
    }

    internal Drink Get(int id)
    {
      Drink burger = _repo.GetById(id);
      if (burger == null)
      {
        throw new Exception("invalid Id");
      }
      return burger;
    }

    internal Drink Create(Drink newDrink)
    {
      return _repo.Create(newDrink);
    }

    internal Drink Edit(Drink editDrink)
    {
      Drink original = Get(editDrink.Id);

      original.Name = editDrink.Name != null ? editDrink.Name : original.Name;
      original.SugarFree = editDrink.SugarFree;
      original.Price = editDrink.Price > 0 ? editDrink.Price : original.Price;

      return _repo.Edit(original);


    }

    internal Drink Delete(int id)
    {

      Drink burger = Get(id);
      _repo.Delete(burger);
      return burger;
    }
  }
}