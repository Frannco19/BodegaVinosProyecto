using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs
{
    public class WineDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Variety { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Region { get; set; } = string.Empty;
        public int Stock { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
