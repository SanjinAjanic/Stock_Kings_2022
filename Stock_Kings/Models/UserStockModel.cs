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
        [Required]
        [Key]
        [ForeignKey("StockModel")]
        public int StockId { get; set; }

        [Required]
        [ForeignKey("Login")]
        public string Email { get; set; }

    }
}
