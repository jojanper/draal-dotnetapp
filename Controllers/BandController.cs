
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace draal.Controllers
{
    [Route("api/[controller]")]
    public class BandController : Controller
    {
        private readonly BandDbContext _context;
        public BandController(BandDbContext context)
        {
            _context = context;
        }

        // GET: api/band
        public IEnumerable<Band> Get()
        {
            return _context.Bands.ToList();
        }

        // GET api/band/5
        [HttpGet("{id}")]
        public Band Get(int id)
        {
            return _context.Bands.FirstOrDefault(x => x.Id == id);
        }

        // POST api/band
        [HttpPost]
        public IActionResult Post([FromBody]Band value)
        {
            _context.Bands.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
    }
}
