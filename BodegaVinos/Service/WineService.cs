using Data.Entities;
using Data.Repository;
using Common.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class WineService
    {
        private readonly IWineRepository _wineRepository;

        public WineService(IWineRepository wineRepository)
        {
            _wineRepository = wineRepository;
        }

        // Registrar un nuevo vino
        public void RegisterWine(WineDTO wineDto)
        {
            var wine = new Wine
            {
                Id = wineDto.Id,
                Name = wineDto.Name,
                Variety = wineDto.Variety,
                Year = wineDto.Year,
                Region = wineDto.Region,
                Stock = wineDto.Stock,
                CreatedAt = wineDto.CreatedAt
            };

            _wineRepository.Add(wine);
        }

        // Obtener un vino por ID
        public Wine GetWineById(int id)
        {
            return _wineRepository.GetById(id);
        }

        // Obtener todos los vinos
        public List<WineDTO> GetAllWines()
        {
            return _wineRepository.GetAll().Select(w => new WineDTO
            {
                Id = w.Id,
                Name = w.Name,
                Variety = w.Variety,
                Year = w.Year,
                Region = w.Region,
                Stock = w.Stock,
                CreatedAt = w.CreatedAt
            }).ToList();
        }


        // Obtener vinos por variedad
        public List<Wine> GetStockWinesByVariety(string variety)
        {
            return _wineRepository.GetStockWineByVariety(variety);
        }

        public void UpdateStock(int id, int newStock)
        {
            _wineRepository.UpdateStock(id, newStock);
        }
    }
}
