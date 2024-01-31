namespace CadastroCliente_001
{
    public class PessoaFisica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public List<Contato> Contatos { get; set; }

        public PessoaFisica()
        {
            Enderecos = new List<Endereco>();
            Contatos = new List<Contato>();
        }
    }

    public class Endereco
    {
        public int Id { get; set; }

        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public int PessoaId { get; set; }
        public PessoaFisica Pessoa { get; set; } // pra andar pelos objetos
    }

    public class Contato
    {
        public int Id { get; set; }

        public string NomeContato { get; set; }
        public string TipoContato { get; set; }
        public string NumeroContato { get; set; }

        public int PessoaId { get; set; }
        public PessoaFisica Pessoa { get; set; } // pra andar pelos objetos
    }

}


