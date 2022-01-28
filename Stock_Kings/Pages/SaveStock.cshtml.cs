using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stock_Kings.Models;
using Stock_Kings.Services.Interfaces;

namespace Stock_Kings.Pages
{
    [Authorize]
    public class SaveStockModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IUserStockRepo _userStockRepo;
        private readonly IStocksRepo _stocksRepo;
        public SaveStockModel(IStocksRepo stocksRepo, IUserStockRepo userStockRepo, UserManager<IdentityUser> userManager)
        {
            _stocksRepo = stocksRepo;
            _userStockRepo = userStockRepo;
            _userManager = userManager;
        }
        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return RedirectToPage("/Index");
            }
            var user = _userManager.GetUserAsync(User).Result;
            var stock = _stocksRepo.GetById((int)id);
            if (stock == null)
            {
                return RedirectToPage("/Index");

            }
            UserStockModel userStockModel = new UserStockModel()
            {
                StockId = stock.Id,
                Email =  user.Email
            };
            
            _userStockRepo.Add(userStockModel);

            return RedirectToPage("/FavouriteStocks");


        }
    }
}
