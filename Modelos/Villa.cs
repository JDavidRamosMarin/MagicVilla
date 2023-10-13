using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla.Modelos
{
    public class Villa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Esta configuracion permite que el id incremente de 1 en 1.
        public int Id { get; set; }
        public string ?Nombre { get; set; }

        public string ?Detalle { get; set; }

        [Required]
        public double Tarifa { get; set; }

        public int Ocupantes { get; set; }

        public double MetroCuadrados { get; set; }

        public string ?ImagenUrl { get; set; }

        public string ?Amenidad { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaActualizacion { get; set; }
    }
}
