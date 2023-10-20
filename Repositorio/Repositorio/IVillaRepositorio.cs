using MagicVilla.Modelos;

namespace MagicVilla.Repositorio.Repositorio
{
    public interface IVillaRepositorio : IRepositorio<Villa>
    {
        Task<Villa> Actualizar(Villa entidad);
    }
}
