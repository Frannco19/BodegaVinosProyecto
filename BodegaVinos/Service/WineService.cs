using Data.Entities;
using Data.Repository;
using Common.DTOs;

namespace Service
{
    public class WineService
    {
        private readonly WineRepository _repository;

        public WineService(WineRepository repository)
        {
            _repository = repository;
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

            _repository.AddWine(wine);
        }

        // Obtener un vino por ID
        public Wine GetWineById(int id)
        {
            return _repository.Wines.FirstOrDefault(w => w.Id == id);
        }

        public List<WineDTO> GetAllWines()
        {
            return _repository.Wines.Select(w => new WineDTO
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


        public void AddStock(int wineId, int amount)
        {
            var wine = GetWineById(wineId);
            if (wine == null) throw new ArgumentException("El vino no existe.");

            wine.AddStock(amount); 
        }

        // Reducir stock de un vino
        public void RemoveStock(int wineId, int amount)
        {
            var wine = GetWineById(wineId);
            if (wine == null) throw new ArgumentException("El vino no existe.");

            wine.RemoveStock(amount); 
        }
    }
}
