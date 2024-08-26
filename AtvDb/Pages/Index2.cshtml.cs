using AtvDb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI;
using System.Collections.Generic;
using System.Threading.Tasks;
public class VeiculoModel : PageModel
{
    private readonly ApplicationDbContext _context;
    public VeiculoModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public IList<Veiculo> Veiculos { get; set; }

    public async Task OnGetAsync()
    {
        Veiculos = await _context.Veiculos.ToListAsync();

    }
   

    public async Task<IActionResult> OnPostAddAsync(Veiculo newVeiculos)
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        _context.Veiculos.Add(newVeiculos);
        await _context.SaveChangesAsync();
        return RedirectToPage();
    }

    public async Task<IActionResult> OnPostDeleteAsync(int id)
    {
        var veiculos = await _context.Veiculos.FindAsync(id);
        if (veiculos != null)
        {
            _context.Veiculos.Remove(veiculos);
            await _context.SaveChangesAsync();
        }
        return RedirectToPage();
    }
}