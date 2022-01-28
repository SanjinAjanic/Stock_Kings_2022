using Stock_Kings.Model;
using Stock_Kings.Models;
using Stock_Kings.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_Kings.Services
{
    public class UserStockRepo : IUserStockRepo
    {
        private readonly AuthDBContext _dBContext;
        public UserStockRepo(AuthDBContext dBContext)
        {
            _dBContext = dBContext;
        }
        public void Add(UserStockModel stock)
        {
            _dBContext.UserStocksR.Add(stock);
            _dBContext.SaveChanges();
        }

        public void Delete(UserStockModel stock)
        {
            _dBContext.UserStocksR.Remove(stock);
            _dBContext.SaveChanges();
        }

        public IEnumerable<UserStockModel> GetAll()
        {
            return _dBContext.UserStocksR;
        }

        public UserStockModel GetById(int id)
        {
            return _dBContext.UserStocksR.FirstOrDefault(s => s.StockId == id);
        }

        public void Update(UserStockModel stock)
        {
            _dBContext.UserStocksR.Attach(stock).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dBContext.SaveChanges();
        }
    }
}
