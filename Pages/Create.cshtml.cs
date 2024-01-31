using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CadastroCliente_001.Pages
{
    public class CreateModel : PageModel
    {
        private readonly CadastroCliente_001.Data.ICadastroCliente_001Context _context;

        public CreateModel(CadastroCliente_001.Data.ICadastroCliente_001Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CadastroCliente_001.PessoaFisica PessoaFisica { get; set; } = default!;
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PessoaFisica.Add(PessoaFisica);
            await _context.SaveChangesAsync();

            return RedirectToPage("./PessoaFisicaPage");
        }
    }
}
