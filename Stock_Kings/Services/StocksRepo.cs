using Stock_Kings.Model;
using Stock_Kings.Models;
using Stock_Kings.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_Kings.Services
{
    public class StocksRepo : IStocksRepo
    {
        private readonly AuthDBContext _dBContext;

        public StocksRepo(AuthDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public void Add(StockModel stock)
        {
            _dBContext.Stocks.Add(stock);
            _dBContext.SaveChanges();
        }

        public void Delete(StockModel stock)
        {
            _dBContext.Stocks.Remove(stock);
            _dBContext.SaveChanges();
        }

        public IEnumerable<StockModel> GetAll()
        {
            return _dBContext.Stocks;
        }

        public StockModel GetById(int id)
        {
            return _dBContext.Stocks.FirstOrDefault(s => s.Id == id);
        }

        public void Update(StockModel stock)
        {
            _dBContext.Stocks.Attach(stock).State= Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dBContext.SaveChanges();
        }
    }
}
