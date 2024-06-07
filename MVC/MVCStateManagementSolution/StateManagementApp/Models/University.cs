using Microsoft.AspNetCore.Mvc.Rendering;

namespace StateManagementApp.Models
{
    public class University
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<SelectListItem> EnggColgList { get; set; }

        public University() 
        {
            EnggColgList = new List<SelectListItem>();
        }
    }
}
