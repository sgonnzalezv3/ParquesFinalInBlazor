using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParquesFinal.Shared.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ParquesFinal.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InformesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public InformesController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<ActividadIlicita>>> Get()
        {
            return await context.ActividadesIlicitas.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<int>> Post(ActividadIlicita actividadIlicita)
        {
            context.Add(actividadIlicita);
            await context.SaveChangesAsync();
            return actividadIlicita.Id;
        }
    }
}

