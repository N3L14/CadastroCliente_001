using Microsoft.EntityFrameworkCore;

namespace CadastroCliente_001.Data
{
    public class ICadastroCliente_001Context : DbContext
    {
        public ICadastroCliente_001Context(DbContextOptions<ICadastroCliente_001Context> options)
            : base(options)
        { }

            public DbSet<CadastroCliente_001.PessoaFisica> PessoaFisica { get; set; } = default!;

        public interface IDbSet<T>
        {
        }


    }

}




    
