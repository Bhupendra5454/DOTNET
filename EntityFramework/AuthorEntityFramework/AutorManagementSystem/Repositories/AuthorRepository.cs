using AuthorManagementSystem.DBContext;
using Microsoft.EntityFrameworkCore;

namespace AuthorManagementSystem.Repositories
{
    public class AuthorRepository
    {
        private AuthorContext _context;

        public AuthorRepository(AuthorContext context)
        {
            _context = context;
        }

        public void ShowAll()
        {
            using (var context = new  AuthorContext())
            {
                var authorWiseBlogs = context.Author.Include(a => a.Blogs).ThenInclude(b => b.Posts).ToList();
                var blogsWisePosts = context.Blog.Include(a => a.Posts).ToList();
                foreach (var author in authorWiseBlogs) 
                { 
                    Console.WriteLine($"Author : {author.Name}");

                    foreach (var blog in author.Blogs)
                    {
                        Console.WriteLine($"Blogs : {blog.Title}");

                        foreach(var post in blog.Posts)
                        {
                            Console.WriteLine($"Posts : {post.Title}");
                            Console.WriteLine($"Description : {post.Description}");
                        }
                    }
                }
            }
        }
      
        public void Initialize()
        {

        }
    }
}
