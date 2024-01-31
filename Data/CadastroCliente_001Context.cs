using Microsoft.EntityFrameworkCore;

namespace CadastroCliente_001.Data
{
    public class CadastroCliente_001Context : ICadastroCliente_001Context
    {

        public CadastroCliente_001Context(DbContextOptions<ICadastroCliente_001Context> options)
           : base(options)
        { 
        }

        public DbSet<CadastroCliente_001.PessoaFisica> PessoaFisica { get; set; } = default!;

    }
}
