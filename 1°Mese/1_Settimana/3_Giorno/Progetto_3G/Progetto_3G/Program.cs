namespace Progetto_3G
{
    class Program
    {

        static void Main(string[] args)
        {
            ContoCorrente conto_giacomino = new ContoCorrente(1400);
            conto_giacomino.prelievo(400);
            conto_giacomino.versamento(600);
        }
    }
}