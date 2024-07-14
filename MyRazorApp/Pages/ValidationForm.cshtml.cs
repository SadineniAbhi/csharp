using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace MyRazorApp.Pages
{
    public class ValidationFormModel : PageModel
    {
        [Required(ErrorMessage = "Please provide your first name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please provide your last name.")]
        public string LastName { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Handle the valid input here (e.g., save to a database)

            return Page();
        }
    }
}
