using System.ComponentModel.DataAnnotations;

namespace MagicVilla.Modelos.DTOs
{
    public class NumeroVillaCreateDto
    {
        [Required]
        public int VillaNo { get; set; }

        [Required]
        public int VillaId { get; set; }

        public string DetalleEspecial { get; set; }
    }
}
