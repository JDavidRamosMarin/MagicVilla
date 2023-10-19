using AutoMapper;
using MagicVilla.Datos;
using MagicVilla.Modelos;
using MagicVilla.Modelos.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        private readonly ILogger<VillaController> logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public VillaController(ILogger<VillaController> logger, 
            ApplicationDbContext context, IMapper mapper)
        {
            this.logger = logger;
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VillaDTOs>>> GetVilla()
        {
            logger.LogInformation("Obtener Villas");
            IEnumerable<Villa> villaList = await context.Villas.ToListAsync();
            return Ok(mapper.Map<IEnumerable<VillaDTOs>>(villaList));
        }

        [HttpGet("{id:int}", Name = "GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<VillaDTOs>> GetVilla(int id)
        {
            if ( id == 0)
            {
                logger.LogError($"Error al traer la Villa con el Id {id}");
                return BadRequest();
            }

            //var villa = VillaStore.villaList.FirstOrDefault(x => x.Id == id);
            var villa = await context.Villas.FirstOrDefaultAsync(x => x.Id == id);

            if ( villa == null ) 
            {
                return NotFound();
            }
            return Ok(mapper.Map<VillaDTOs>(villa));


        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<VillaDTOs>> CrearVilla([FromBody] VillaCreacionDTO createDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await context.Villas.FirstOrDefaultAsync(x => x.Nombre.ToLower() == createDto.Nombre.ToLower()) != null)
            {
                ModelState.AddModelError("NombreExiste", "La Villa con ese nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (createDto == null)
            {
                return BadRequest();
            }

            Villa modelo = mapper.Map<Villa>(createDto);

            await context.Villas.AddAsync(modelo);
            await context.SaveChangesAsync();

            return CreatedAtRoute("GetVilla", new { id = modelo.Id }, modelo);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var villa = await context.Villas.FirstOrDefaultAsync(x => x.Id == id);

            if (villa == null)
            {
                return NotFound();
            }

            context.Villas.Remove(villa);
            await context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateVilla(int id, [FromBody] VillaUpdateDTO villaUpdateDto)
        {
            if (villaUpdateDto == null || id != villaUpdateDto.Id)
            {
                return BadRequest();
            }

            Villa modelo = mapper.Map<Villa>(villaUpdateDto);

            context.Villas.Update(modelo);
            await context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialVilla(int id, JsonPatchDocument<VillaUpdateDTO> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }
            var villa = await context.Villas.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

            VillaUpdateDTO villaDto = mapper.Map<VillaUpdateDTO>(villa);

            if (villa == null)
            {
                return BadRequest();
            }

            patchDto.ApplyTo(villaDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            Villa modelo = mapper.Map<Villa>(villaDto);

            context.Villas.Update(modelo);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}
