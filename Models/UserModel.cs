using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Markets.Models
{
  public class UserModel
  {
    public int Id { get; set; }
    public string Name {get; set;}
    public string StockString {get; set;}

  }
}
