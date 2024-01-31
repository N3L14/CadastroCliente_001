namespace CadastroCliente_001
{
    public class LoginService
    {
        public bool Authenticate(string email, string password)
        {
            // aqui poderia ser feita uma consulta ao banco de dados, mas coloquei um valor fixo.
            return email == "fulano@email.com" && password == "senha123";
        }
    }
}
