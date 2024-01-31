using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CadastroCliente_001.Pages
{
    public class EditModel : PageModel
    {
        private readonly CadastroCliente_001.Data.ICadastroCliente_001Context _context;

        public EditModel(CadastroCliente_001.Data.ICadastroCliente_001Context context)
        {
            _context = context;
        }

        [BindProperty]

        public PessoaFisica PessoaFisica { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var PessoaFisica = await _context.PessoaFisica.FirstOrDefaultAsync(m => m.Id == id);
            if (PessoaFisica == null)
            {
                return NotFound();
            }
            else
            {
                PessoaFisica = PessoaFisica;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PessoaFisica).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PessoaFisicaExists(PessoaFisica.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./PessoaFisicaPage");
        }

        private bool PessoaFisicaExists(int id)
        {
            return _context.PessoaFisica.Any(e => e.Id == id);
        }
    }
}