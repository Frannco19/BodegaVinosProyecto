using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class WineRepository : IWineRepository
    {
        private readonly BodegaContext _context;

        public WineRepository(BodegaContext context)
        {
            _context = context;
        }
        // Segundo Endpoint 
        public List<Wine> GetAll()
        {
            return _context.Wines.ToList();
        }
        // Bonus buscar por Id 
        public Wine GetById(int id)
        {
            return _context.Wines.Find(id);
        }
        public void Add(Wine wine)
        {
            _context.Wines.Add(wine);
            _context.SaveChanges();
        }  

        // Cuarto Endpoint
        public List<Wine> GetStockWineByVariety(string variety)
        {
            return _context.Wines
                .Where(w => w.Variety == variety && w.Stock > 0)
                .ToList();
        }
        // bonus 
        public void UpdateStock(int id, int newStock)
        {
            var wine = _context.Wines.Find(id);
            if (wine != null)
            {
                wine.Stock = newStock;
                _context.SaveChanges(); 
            }
        }
    }
}
