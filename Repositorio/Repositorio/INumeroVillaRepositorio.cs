using MagicVilla.Modelos;

namespace MagicVilla.Repositorio.Repositorio
{
    public interface INumeroVillaRepositorio : IRepositorio<NumeroVilla>
    {
        Task<NumeroVilla> Actualizar(NumeroVilla entidad);
    }
}
