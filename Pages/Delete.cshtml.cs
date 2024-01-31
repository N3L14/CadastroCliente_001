using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CadastroCliente_001.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly CadastroCliente_001.Data.ICadastroCliente_001Context _context;

        public DeleteModel(CadastroCliente_001.Data.ICadastroCliente_001Context context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var PessoaFisica = await _context.PessoaFisica.FindAsync(id);
            if (PessoaFisica != null)
            {
                PessoaFisica = PessoaFisica;
                _context.PessoaFisica.Remove(PessoaFisica);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./PessoaFisicaPage");
        }
    }
}