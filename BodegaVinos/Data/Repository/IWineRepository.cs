using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public interface IWineRepository
    {
        List<Wine> GetStockWineByVariety(string variety);
        List<Wine> GetAll();
        Wine GetById(int id);
        void Add(Wine wine);
        void UpdateStock(int id, int newStock);

    }
}
