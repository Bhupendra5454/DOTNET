﻿
namespace AuthorManagementSystem.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public List<Post> Posts { get; set; }
    }
}
