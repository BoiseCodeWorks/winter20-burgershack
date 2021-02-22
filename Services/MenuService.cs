using System;
using System.Collections.Generic;
using burgershack_winter20.Models;
using burgershack_winter20.Repositories;

namespace winter20_burgershack.Services
{
  public class MenuService
  {
    private readonly MenuRepository _repo;

    public MenuService(MenuRepository repo)
    {
      _repo = repo;
    }
    internal IEnumerable<MenuItem> getAll()
    {
      return _repo.GetAll();
    }
  }
}