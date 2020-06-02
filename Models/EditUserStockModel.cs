using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Markets.Models
{
  public class EditUserStockModel
  {
    [Required]
    public string StockString {get; set;}

  }
}
