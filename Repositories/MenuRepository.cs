using System.Collections.Generic;
using System.Data;
using burgershack_winter20.Models;
using Dapper;

namespace burgershack_winter20.Repositories
{
  public class MenuRepository
  {
    public readonly IDbConnection _db;

    public MenuRepository(IDbConnection db)
    {
      _db = db;
    }
    //NOTE dotnet add package dapper - to be able to communicate with db
    public IEnumerable<MenuItem> GetAll()
    {
      string sql = "SELECT * FROM burgers, drinks, sides;";
      return _db.Query<MenuItem>(sql);
    }
  }
}