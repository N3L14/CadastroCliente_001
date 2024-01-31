using Microsoft.AspNetCore.Mvc;

namespace CadastroCliente_001.Controllers
{
    public class HomeController : Controller
    {
        private readonly CadastroCliente_001.Data.ICadastroCliente_001Context _context;

        public HomeController(CadastroCliente_001.Data.ICadastroCliente_001Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
