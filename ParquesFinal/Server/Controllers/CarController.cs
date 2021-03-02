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
    public class CarController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public CarController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Car>>> Get()
        {
            return await context.Cars.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<int>> Post(Car car)
        {
            context.Add(car);
            await context.SaveChangesAsync();
            return car.Id;
        }
    }
}
