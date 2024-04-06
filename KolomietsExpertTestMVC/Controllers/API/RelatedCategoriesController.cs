using KolomietsExpertTestMVC.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KolomietsExpertTestMVC.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelatedCategoriesController : ControllerBase
    {
        private readonly ExpertContext _context;
        public RelatedCategoriesController(ExpertContext context)
        {
            _context = context;
        }

        [HttpGet("get/{id}/{filmId}")]
        public async Task<IDictionary<bool, Category>?> Get(int id, int filmId)
        {
            var relatedCategories = await _context.Categories
              .Where(c => c.ParentCategoryId == id)
              .ToListAsync();

            var categoryGenreMap = new Dictionary<bool, Category>();

            foreach (var category in relatedCategories)
            {
                bool hasGenre = await _context.FilmCategories
                  .AnyAsync(fc => fc.FilmId == filmId && fc.CategoryId == category.Id);

                categoryGenreMap.Add(hasGenre, category);
            }

            return categoryGenreMap;
        }

        [HttpPost("create")]
        public async Task Create([FromBody] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
            }
        }

    }
}
