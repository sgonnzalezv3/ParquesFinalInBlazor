using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParquesFinal.Server.Helpers;
using ParquesFinal.Shared.DTOs;
using ParquesFinal.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParquesFinal.Server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ParquesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IAlmacenadorDeArchivos almacenadorDeArchivos;
        public ParquesController(ApplicationDbContext context, IAlmacenadorDeArchivos almacenadorDeArchivos)
        {
            this.context = context;
            this.almacenadorDeArchivos = almacenadorDeArchivos;
        }
        [HttpGet]
        public async Task<ActionResult<List<Parque>>> Get()
        {
            return await context.Parques.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Parque>> Get(int id)
        {   
                var parque = context.Parques.FirstOrDefaultAsync(x => x.Id == id);
                return await parque;
            
            /*var parque = await context.Parques.Where(x => x.Id == id).Include(x => x.Nombre)
                .Include(x => x.ParqueEcosistemas).Include(x => x.Administrador).Include(x => x.Personales)
                .FirstOrDefaultAsync();
            if(parque == null) { return NotFound(); }
            var model = new ParqueVisualizarDTO();
            model.Parque = parque;
            model.Ecosistemas = parque.ParqueEcosistemas.Select(x => x.Ecosistema).ToList();
            model.ZonasAlojamiento = parque.ZonasDeAlojamiento.ToList();
            model.Administrador = parque.Administrador;
            model.Personales = parque.Personales.ToList();
            return model; */
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Parque parque)
        {
            if (!string.IsNullOrWhiteSpace(parque.Img))
            {
                var fotoParque = Convert.FromBase64String(parque.Img);
                parque.Img = await almacenadorDeArchivos.GuardarArchivo(fotoParque, "jpg", "parques");
            }
            context.Add(parque);
            await context.SaveChangesAsync();
            return parque.Id;
        }
    }
}
