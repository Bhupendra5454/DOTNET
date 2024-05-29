using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace bloggersPostWeb.Pages
{

    //Code behind File Approach
    public class tapModel : PageModel
    {
        public void OnGet()
        {
            Console.WriteLine("Page requrest is received from client");
        }

        public void OnPost() {
            Console.WriteLine("Page is posted due to submit action....");
        }
    }
}
