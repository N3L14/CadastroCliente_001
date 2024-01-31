using CadastroCliente_001.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace CadastroCliente_001.Pages
{
    public class PessoaFisicaPageModel : PageModel
    {
        private readonly CadastroCliente_001.Data.ICadastroCliente_001Context _context;

        public PessoaFisicaPageModel(ICadastroCliente_001Context context)
        {
            _context = context;
        }

        public IList<PessoaFisica> PessoaFisica { get; set; } = default;

        public async Task OnGetAsync()
        {
            PessoaFisica = await _context.PessoaFisica.ToListAsync();
        }
    }
}