using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CadastroCliente_001.Pages
{

    public class CadastroPessoaFisicaModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost()
        {
            var pessoaFisica = new PessoaFisica
            {
                Nome = Request.Form["Nome"],
                Sobrenome = Request.Form["Sobrenome"],
                DataNascimento = System.DateTime.Parse(Request.Form["DataNascimento"]),
                Email = Request.Form["Email"],
                CPF = Request.Form["CPF"],
                RG = Request.Form["RG"]
            };

            pessoaFisica.Enderecos.Add(new Endereco
            {
                Logradouro = Request.Form["Logradouro"],
                Numero = Request.Form["Numero"],
                CEP = Request.Form["CEP"],
                Complemento = Request.Form["Complemento"],
                Cidade = Request.Form["Cidade"],
                Estado = Request.Form["Estado"]
            });

            pessoaFisica.Contatos.Add(new Contato
            {
                NomeContato = Request.Form["NomeContato"],
                TipoContato = Request.Form["TipoContato"],
                NumeroContato = Request.Form["NumeroContato"]
            });

        }
    }
}
