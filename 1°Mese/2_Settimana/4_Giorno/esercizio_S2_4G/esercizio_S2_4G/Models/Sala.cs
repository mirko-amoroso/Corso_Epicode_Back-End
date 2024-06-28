namespace esercizio_S2_4G.Models
{
    public class Sala
    {
        public string nome {  get; set; } 
        public List<Utente> UtenteList { get; set; } = new List<Utente>();

        public Sala(string Nome) 
        {
            nome = Nome;
        }
    }
}
