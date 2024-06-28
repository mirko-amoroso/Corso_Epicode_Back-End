namespace Progetto_2S_2G.Models
{
    public class infoPerso
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public infoPerso( string nome, string cognome, string telefono, string email)
        {
            Nome = nome;
            Cognome = cognome;
            Telefono = telefono;
            Email = email;
        }

    }
}
