using System;
using System.Collections.Generic;

namespace AuthorManagementSystem.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Blog> Blogs { get; set; }
     
    }
}
