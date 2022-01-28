using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_Kings.Models
{
    public class UserStockModel
    {
        public int Id { get; set; }
        public int? StockId { get; set; }
        public string? Email { get; set; }
        public bool IsFavourite { get; set; }

    }
}
