using System;
using System.Collections.Generic;
using burgershack_winter20.Models;
using burgershack_winter20.Repositories;

namespace burgershack_winter20.Services
{
  public class SideService
  {

    private readonly SideRepository _repo;

    public SideService(SideRepository repo)
    {
      _repo = repo;
    }

    internal IEnumerable<Side> Get()
    {
      return _repo.GetAll();
    }

    internal Side Get(int id)
    {
      Side burger = _repo.GetById(id);
      if (burger == null)
      {
        throw new Exception("invalid Id");
      }
      return burger;
    }

    internal Side Create(Side newSide)
    {
      return _repo.Create(newSide);
    }

    internal Side Edit(Side editSide)
    {
      Side original = Get(editSide.Id);

      original.Name = editSide.Name != null ? editSide.Name : original.Name;
      original.Price = editSide.Price > 0 ? editSide.Price : original.Price;

      return _repo.Edit(original);


    }

    internal Side Delete(int id)
    {

      Side burger = Get(id);
      _repo.Delete(burger);
      return burger;
    }
  }
}