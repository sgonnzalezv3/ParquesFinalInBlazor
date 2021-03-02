using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParquesFinal.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParquesFinal.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HabitacionesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public HabitacionesController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<ZonaAlojamiento>>> Get()
        {
            return await context.ZonasDeAlojamiento.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<int>> Post(ZonaAlojamiento zonaAlojamiento)
        {
            context.Add(zonaAlojamiento);
            await context.SaveChangesAsync();
            return zonaAlojamiento.Id;
        }
    }
}
