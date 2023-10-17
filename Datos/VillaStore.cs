using MagicVilla.Modelos.DTOs;

namespace MagicVilla.Datos
{
    public class VillaStore
    {
        public static List<VillaDTOs> villaList = new List<VillaDTOs>
        {
            new VillaDTOs{Id=1, Nombre="Vista a la Piscina", Ocupantes = 3, MetrosCuadrados = 50},
            new VillaDTOs{Id=2, Nombre="Vista a la Playa", Ocupantes = 4, MetrosCuadrados = 80}
        };
            
    }
}
