using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly DataContext _context;

        public EventController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
           

            return _context.Events;

        }
          [HttpGet("{index}")]
        public IEnumerable<Event> Get(int index)
        {
            
            
            return _context.Events.Where(x=>x.Id == index);
        }
    }
}
