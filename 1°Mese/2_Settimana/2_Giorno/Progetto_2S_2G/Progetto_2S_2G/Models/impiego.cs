namespace Progetto_2S_2G.Models
{
    public class impieghi
    {
        public List<esperienza> esperienze { get; set; }

        public impieghi (List<esperienza> esperienze)
        {
            this.esperienze = esperienze;
        }
    }
}



