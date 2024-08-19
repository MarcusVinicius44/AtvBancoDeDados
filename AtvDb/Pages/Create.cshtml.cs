using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using AtvDb.Models;

namespace AtvDb.Pages
{
    public class CreateModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private readonly ApplicationDbContext _context;
        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Student Student { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Students.Add(Student);
            _context.SaveChanges();
            return RedirectToPage("./Index");
        }
    }
}