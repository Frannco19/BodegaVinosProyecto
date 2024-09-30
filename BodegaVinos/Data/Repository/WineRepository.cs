using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class WineRepository
    {
        public List<Wine> Wines { get; set; } =  new List<Wine>();
        public void AddWine(Wine wine)
        {
            Wines.Add(wine);
        }
    }
}
