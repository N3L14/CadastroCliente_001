using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CadastroCliente_001.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost()
        {
            string email = Request.Form["email"];
            string password = Request.Form["password"];

            LoginService loginService = new LoginService();

            if (loginService.Authenticate(email, password))
            {

                Response.Redirect("/PessoaFisicaPage");

            }
            else
            {

                Response.Redirect("/denied");
            }
        }
    }
}