using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ogani.Application.Models.DataContext;

namespace Ogani.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class BlogsController : ControllerBase
    {

        readonly OganiDbContext db;

        public BlogsController(OganiDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll (int pageIndex = 1, int pageSize = 6, int? categoryId = null, int? tagId = null)
        {
            var query = db.Blogs.AsQueryable();

            if (categoryId != null)
            {
                query = query.Where(b => b.BlogCategoryId == categoryId);
            }
            if (tagId != null)
            {
                query = query.Where(b => b.BlogTagBlogs.Any(btb => btb.BlogTagId == tagId));
            }

            query = query.Where(b => b.DeletedDate == null && b.PublishedDate != null)
                .Include(b => b.Author)
                .AsQueryable();

            return Ok(await query.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id < 0)
                return NotFound();

            var entity = await db.Blogs
                .Where(b => b.PublishedDate != null)
                .Include(b => b.BlogCategory)
                .Include(b => b.Author)
                .Include(b => b.BlogTagBlogs)
                .ThenInclude(bt => bt.BlogTag)
                .FirstOrDefaultAsync(b => b.Id == id && b.DeletedDate == null);

            if (entity == null)
                return NotFound();

            return Ok(entity);
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

