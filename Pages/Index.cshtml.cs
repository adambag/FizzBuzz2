using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FizzBuzz.Forms;

namespace FizzBuzz.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]

        public FizzBuzzForm FizzBuzz { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }

        public string Result { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                IfDivided(FizzBuzz.Number);
                return Page();
            }           
            return RedirectToPage("./Privacy");
        }
        public void IfDivided(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                Result = "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                Result =  "Fizz";
            }
            else if (number % 5 == 0)
            {
                Result = "Buzz";
            }
           
            else
            {
                Result = "Liczba " + number + " nie spełnia warunkow FizzBuzz";

            }
        }


        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";
            }

        }
    }
}