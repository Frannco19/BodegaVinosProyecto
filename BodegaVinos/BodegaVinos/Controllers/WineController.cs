using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using Common.DTOs;

namespace BodegaDeVinos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WineController : ControllerBase
    {
        private readonly WineService _wineService;

        public WineController(WineService wineService)
        {
            _wineService = wineService;
        }

        [HttpPost]
        public IActionResult RegisterWine([FromBody] WineDTO wine)
        {
            if (wine == null) return BadRequest("Los detalles del vino no pueden ser nulos.");

            _wineService.RegisterWine(wine);
            return CreatedAtAction(nameof(GetWineById), new { id = wine.Id }, wine);
        }

        [HttpGet]
        public ActionResult<List<WineDTO>> GetAllWines()
        {
            var wines = _wineService.GetAllWines();
            return Ok(wines);
        }

        // Obtener vino por ID
        [HttpGet("{id}")]
        public ActionResult<WineDTO> GetWineById(int id)
        {
            var wineDto = _wineService.GetWineById(id);
            if (wineDto == null) return NotFound("El vino no existe.");
            return Ok(wineDto);
        }
    }

}
