using Stock_Kings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_Kings.Services.Interfaces
{
    /// <summary>
    /// skapar interface av stockreposetory.
    /// </summary>
    public interface IStocksRepo
    {
        void Add(StockModel stock);
        void Delete(StockModel stock);
        void Update(StockModel stock);

        StockModel GetById(int id);

        IEnumerable<StockModel> GetAll();



    }
}
