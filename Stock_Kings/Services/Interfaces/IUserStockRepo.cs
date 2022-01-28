using Stock_Kings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_Kings.Services.Interfaces
{
    /// <summary>
    /// skapar interface av stockrepo.
    /// </summary>
    public interface IUserStockRepo
    {
        void Add(UserStockModel stock);
        void Delete(UserStockModel stock);
        void Update(UserStockModel stock);

        UserStockModel GetById(int id);

        IEnumerable<UserStockModel> GetAll();



    }
}
