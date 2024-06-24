namespace progetto_S2_G1.Models
{
    public class Alimento
    {
        public string nome { get; set; }

        public double prize { get; set; }

        public Alimento(string Nome, double Prize)
        {
            nome = Nome;
            prize = Prize;
        }

        public void AlimentoMenu(string numero)
        {
            Console.WriteLine($"{numero}:{nome} {prize} euro");
        }
    }
}
