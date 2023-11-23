using System.Linq.Expressions;

namespace MagicVilla.Repositorio.Repositorio
{
    public interface IRepositorio<T> where T : class
    {
        Task Crear(T entidad);
        Task<List<T>> ObtenerTodos(Expression<Func<T, bool>> filtro = null, string incluirPropiedad = null);
        Task<T> Obtener(Expression<Func<T, bool>> filtro = null, bool tracked = true, string incluirPropiedad = null);
        Task Remover(T entidad);
        Task Grabar();
    }
}
