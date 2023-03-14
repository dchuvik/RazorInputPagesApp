using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorInputPages.Pages
{
    public class AddressInfoModel : PageModel
    {
        [BindProperty]
        public int AddressNumber { get; set; }
        [BindProperty]
        public string AddressStreet { get; set; }
        [BindProperty]
        public string City { get; set; }
        [BindProperty]
        public string State { get; set; }
        [BindProperty]
        public string ZipCode { get; set; }
        [BindProperty]
        public List<string> FullAddresses { get; set; } = new List<string>();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            string fullAddress = $"{AddressStreet} {City} {State}, {ZipCode}";
            FullAddresses.Add(fullAddress);
            return Page();
        }
    }
}
