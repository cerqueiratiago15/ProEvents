using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {

        public EventController()
        {
          
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return new Event[]{new Event(){Id=1, Theme="Angular", Adress="Itatiaia", Capacity=200, Date=DateTime.Now.Add(TimeSpan.FromDays(20)), ImageUrl="Photo.png"}};
        }
    }
}
