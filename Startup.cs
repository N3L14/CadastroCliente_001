using CadastroCliente_001.Data;
using Microsoft.EntityFrameworkCore;

namespace CadastroCliente_001
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<ICadastroCliente_001Context>(options =>
            {
                options.UseSqlServer("CadastroCliente_001Context");
            });

            services.AddHttpContextAccessor();

            services.AddMvc();

        }
    }
}
