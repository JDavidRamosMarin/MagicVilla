using System.ComponentModel.DataAnnotations;

namespace MagicVilla.Modelos.DTOs
{
    public class VillaDTOs
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }
        public int Ocupantes { get; set; }
        public int MetrosCuadrados { get; set; }
    }
}
