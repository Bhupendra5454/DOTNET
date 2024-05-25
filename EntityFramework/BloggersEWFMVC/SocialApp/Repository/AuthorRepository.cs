using AuthorManagementSystem.DBContext;
using AuthorManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AuthorManagementSystem.Repositories
{
    public class AuthorRepository
    {
        private AuthorContext _context;

        public AuthorRepository(AuthorContext context)
        {
            _context = context;
        }

        public List<Author> ShowAll()
        {
            using (var context = new  AuthorContext())
            {
                var authorWiseBlogs = context.Author.ToList();//Include(a => a.Blogs).ThenInclude(b => b.Posts).ToList();
                return authorWiseBlogs;
            }
        }
      
        public void Initialize()
        {
            using (var context = new AuthorContext()) 
            {
                var author = new Author { Name = "Bhupendra Walhekar" };
                author.Blogs = new List<Blog> {
                 new Blog{Title = "Travel" ,
                 Posts= new List<Post>
                {
                  new Post{Title="World Of Travel",Description = "Travel offers the opportunity to explore new cultures, cuisines and landscapes" }
                }
                }
               
                 };
                context.Author.Add(author);
                context.SaveChanges();

            }

        }
    }
}
