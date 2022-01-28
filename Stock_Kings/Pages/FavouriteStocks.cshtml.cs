using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Stock_Kings.Model;
using Stock_Kings.Models;
using Stock_Kings.Services.Interfaces;

namespace Stock_Kings.Pages
{
    [Authorize]
    public class FavouriteStocksModel : PageModel
    {
        private readonly Stock_Kings.Model.AuthDBContext _context;
        private readonly IUserStockRepo _userStockRepo;
        private readonly IStocksRepo _stocksRepo;
        private readonly UserManager<IdentityUser> _userManager;
        public FavouriteStocksModel(IUserStockRepo userStockRepo, IStocksRepo stocksRepo, UserManager<IdentityUser> userManager)
        {
            _userStockRepo = userStockRepo;
            _stocksRepo = stocksRepo;
            _userManager = userManager;
        }

        public IList<StockModel> StockModel { get; set; } = new List<StockModel>();
        

        public async Task OnGetAsync()
        {

            var user = await _userManager.GetUserAsync(User);
            var userStocks = _userStockRepo.GetAll().Where(x => x.Email == user.Email).ToList();
            foreach (var item in userStocks)
            {
                var stock = _stocksRepo.GetById((int)item.StockId);
                StockModel.Add(stock);
            }
        }
    }
}
