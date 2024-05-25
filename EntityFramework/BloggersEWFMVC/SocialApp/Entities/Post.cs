
namespace AuthorManagementSystem.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Blog Blog { get; set; }
    }
}
