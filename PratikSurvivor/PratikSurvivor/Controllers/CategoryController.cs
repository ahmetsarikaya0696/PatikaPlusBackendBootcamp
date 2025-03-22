using Microsoft.AspNetCore.Mvc;
using PratikSurvivor.Contexts;
using PratikSurvivor.Dtos;
using PratikSurvivor.Models;

namespace PratikSurvivor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
            return Ok(_context.Categories.Where(c => !c.IsDeleted);
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var category = _context.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpPost]
        public IActionResult CreateCategory([FromBody] CreateCategoryDto dto)
        {
            _context.Categories.Add(new Category() { Name = dto.Name, CreatedDate = DateTime.Now, IsDeleted = false });
            _context.SaveChanges();
            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCategory(int id, [FromBody] UpdateCategoryDto dto)
        {
            if (id != dto.Id)
            {
                return BadRequest();
            }

            var category = _context.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }

            _context.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            category.ModifiedDate = DateTime.Now;

            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var category = _context.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }

            _context.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            category.IsDeleted = true;
            
            _context.SaveChanges();
            return NoContent();
        }
    }
}
