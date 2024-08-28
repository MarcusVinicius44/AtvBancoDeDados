using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using AtvDb.Models;

namespace AtvDb.Pages
{
    public class VeiculosModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private readonly ApplicationDbContext _context;
        public VeiculosModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Veiculo Veiculo { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Veiculos.Add(Veiculo);
            _context.SaveChanges();
            return RedirectToPage("./Index");
        }
    }
}