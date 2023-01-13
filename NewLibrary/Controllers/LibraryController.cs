using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewLibrary.Data;
using NewLibrary.Models;

namespace NewLibrary.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibraryController : Controller
    {
        private readonly LibraryApiDbContext dbContext;

        public LibraryController(LibraryApiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetLibrary()
        {
            return Ok(await dbContext.BookAuthors.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddAuthor(AddAuthorRequest addAuthorRequest)
        {
            var author = new Author()
            {
                Id = Guid.NewGuid(),
                FirstName = addAuthorRequest.FirstName,
                LastName = addAuthorRequest.LastName,
                BirthDate = addAuthorRequest.BirthDate,
                Gender = addAuthorRequest.Gender
            };
            await dbContext.Authors.AddAsync(author);
            await dbContext.SaveChangesAsync();
            return Ok(author);
        }
    }
}
