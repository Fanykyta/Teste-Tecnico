namespace PessoasApi.Models
{
    public class Pessoa
    {
        public string Cpf { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public int Idade { get; set; }
        public string Municipio { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
    }
}
