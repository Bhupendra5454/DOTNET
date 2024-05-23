using AuthorManagementSystem.DBContext;
using AuthorManagementSystem.Repositories;

using (var context = new AuthorContext())
{
    AuthorRepository repo = new AuthorRepository(context);
   
    repo.ShowAll();
}