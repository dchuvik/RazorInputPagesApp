using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorInputPages.Pages
{
    public class PersonInfoModel : PageModel
    {
        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]
        public int Age { get; set; }
        [BindProperty]
        public List<string> FullNames { get; set; } = new List<string>();
     
        public void OnGet()
        {
        }

        public void OnPost()
        {
            string fullInfo = $"{FirstName} {LastName}, you are {Age}";
            FullNames.Add(fullInfo);
        }
    }
}
