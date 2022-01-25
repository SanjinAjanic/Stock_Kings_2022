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
        /// <summary>
        /// Skapat en querry som joinar stocks och userstocks.
        /// </summary>
        /// <returns></returns>
        public List<StockListItem> getStockList()
        {
            return Stocks.Select(stock => new StockListItem { StockName = stock.Name, StockPrice = stock.Price }).ToList();
            // return  Stocks.Join(UserStocks, stock => stock.Id, userStock => userStock.StockId, (stock,  userStock ) => new StockListItem {Email = userStock.Email, StockName = stock.Name, StockPrice = stock.Price }).ToList();
        } 
    }
}
