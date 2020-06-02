using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Markets.Models;

namespace Markets.Data
{
  public class UserData : IUserData
  {
    private readonly ApplicationDbContext _db;
    public UserData(ApplicationDbContext db)
    {
      _db = db;
    }

    public UserModel GetPerson(string name)
    {
      return _db.UsersData.FirstOrDefault( s => s.Name == name);
    }

    public void UpsertPerson(UserModel user)
    {
        var checkForUser = _db.UsersData.FirstOrDefault( s => s.Name == user.Name);

      if (checkForUser != null)
      {
        checkForUser.StockString = user.StockString;
        var saveResult = _db.SaveChanges();

      }
      else
      {
        _db.Add(user);
        var saveResult = _db.SaveChanges();
      }
    }
  }
}