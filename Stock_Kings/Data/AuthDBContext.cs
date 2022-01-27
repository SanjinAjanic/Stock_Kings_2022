using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Stock_Kings.Models;
using Stock_Kings.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_Kings.Model

{

public class AuthDBContext: IdentityDbContext
    {
        public AuthDBContext(DbContextOptions<AuthDBContext> options): base(options)
        {
    
        }
        public DbSet<StockModel> Stocks { get; set; }
        public DbSet<UserStockModel> UserStocks { get; set; }
        public DbSet<UserFavStock> UserFavStocks { get; set; }

    }
}
