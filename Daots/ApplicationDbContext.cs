using MagicVilla.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla.Daots
{
    public class ApplicationDbContext :DbContext
    {
        protected ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        /*public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
{

}*/

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id=1,
                    Nombre="Villa Real",
                    Detalle="Detalle de la Villa",
                    ImagenUrl="",
                    Ocupantes=5,
                    MetroCuadrados=50,
                    Tarifa=500,
                    Amenidad="",
                    FechaCreacion=DateTime.Now,
                    FechaActualizacion=DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Nombre = "Premium Vista a la Piscina",
                    Detalle = "Detalle de la Villa",
                    ImagenUrl = "",
                    Ocupantes = 4,
                    MetroCuadrados = 40,
                    Tarifa = 150,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                }
                );
        }
    }
}
