using AuthorManagementSystem.DBContext;
using AuthorManagementSystem.Entities;
using AuthorManagementSystem.Repositories;

using (var context = new AuthorContext())
{
    AuthorRepository repo = new AuthorRepository(context);
   
    repo.Initialize();
    repo.ShowAll();
    
}