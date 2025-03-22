using Microsoft.AspNetCore.Mvc;
using PratikSurvivor.Contexts;
using PratikSurvivor.Dtos;
using PratikSurvivor.Models;

namespace PratikSurvivor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CompetitorController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Competitors.Where(c => !c.IsDeleted);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var competitor = _context.Competitors.Find(id);
            if (competitor == null)
            {
                return NotFound();
            }
            return Ok(competitor);
        }

        [HttpGet("categories/{categoryId}")]
        public IActionResult GetByCategory(int categoryId)
        {
            var competitors = _context.Competitors.Where(c => c.CategoryId == categoryId);
            return Ok(competitors);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateCompetitorDto dto)
        {
            _context.Competitors.Add(new Competitor()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                CategoryId = dto.CategoryId,
                CreatedDate = DateTime.Now,
                IsDeleted = false
            });

            _context.SaveChanges();
            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateCompetitorDto dto)
        {
            var competitor = _context.Competitors.Find(id);
            if (competitor == null)
            {
                return NotFound();
            }
            competitor.FirstName = dto.FirstName;
            competitor.LastName = dto.LastName;
            competitor.CategoryId = dto.CategoryId;
            competitor.ModifiedDate = DateTime.Now;

            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var competitor = _context.Competitors.Find(id);
            if (competitor == null)
            {
                return NotFound();
            }
            competitor.IsDeleted = true;
            _context.SaveChanges();
            return NoContent();
        }
    }
}
