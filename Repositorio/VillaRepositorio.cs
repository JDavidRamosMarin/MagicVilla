using MagicVilla.Datos;
using MagicVilla.Modelos;
using MagicVilla.Repositorio.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla.Repositorio
{
    public class VillaRepositorio : Repositorio<Villa>, IVillaRepositorio
    {
        private readonly ApplicationDbContext _context;

        public VillaRepositorio(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Villa> Actualizar(Villa entidad)
        {
            entidad.FechaActualizacion = DateTime.Now;
            _context.Villas.Update(entidad);
            await _context.SaveChangesAsync();
            return entidad;
        }

    }
}
