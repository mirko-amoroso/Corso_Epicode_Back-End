using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using esercizio_2G;

namespace esercizio_2G
{
    internal class Persona
    {
        string nome;
        string cognome;
        int eta;

        public string Nome
        {
            get { return nome; }
        } 
        public string Cognome
        {
            get { return cognome; }
        } 
        public int Eta
        {
            get { return eta; }
        }


        public Persona(string nome, string cognome, int eta)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
        }

        public void getNome()
        {
            Console.WriteLine("il suo nome è: " + this.nome);
        }

        public void getCognome()
        {
            Console.WriteLine("il suo cognome è: " + this.cognome);
        }

        public void getEta()
        {
            Console.WriteLine("la sua età è: " + this.eta);
        }  
        public void getDetails()
        {
            Console.WriteLine("le sue info sono: \nnome " + this.nome + "; \n" + "cognome " + this.cognome + "; \n" + "eta " + this.eta + ";");
        }
    }
}
