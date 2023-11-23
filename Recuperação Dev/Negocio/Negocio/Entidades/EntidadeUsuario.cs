namespace Negocio.Entidades
{
    public class EntidadeUsuario
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public DateTime Contato { get; set; }
        public string Cargo { get; set; }
        public string Empresa { get; set; }
        public EntidadeUsuario(string nome, string telefone, string email, string endereco)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
        }
    }
}
