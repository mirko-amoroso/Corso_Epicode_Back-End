namespace progetto_S2_G1.Models
{
    public class Ordinazione
    {
        public List<Alimento> Alimenti { get; set; }

        public Ordinazione()
        {
            Alimenti = new List<Alimento>();
        }

        public  void aggiungi(Alimento o) {  Alimenti.Add(o); }

        private double somma() 
        {
            double totale = 0;
            foreach (Alimento numero in Alimenti)
            {
                totale += numero.prize;
            }
            return totale;
        }

        public void finale ()
        {
            foreach (Alimento elemnt in Alimenti)
            {
                Console.WriteLine($"{elemnt.nome}: {elemnt.prize} euro");
            }
            Console.WriteLine($"prezzo totale: {somma()} euro");
        }


    }
}
