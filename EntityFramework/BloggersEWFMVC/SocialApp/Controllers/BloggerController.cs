using AuthorManagementSystem.DBContext;
using AuthorManagementSystem.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace SocialApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BloggerController : ControllerBase
    {
        private readonly ILogger<BloggerController> _logger;

        public BloggerController(ILogger<BloggerController> logger)
        {
            _logger = logger;
        }

        [HttpGet ("allblogs")]
        public IActionResult Get()
        {
            using (var context = new AuthorContext())
            {
                AuthorRepository repo = new AuthorRepository(context);
                repo.ShowAll();
                return Ok(repo);

            }
        }
    }
}
