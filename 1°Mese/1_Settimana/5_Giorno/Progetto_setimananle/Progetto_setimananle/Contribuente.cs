using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_setimananle
{
    internal class Contribuente
    {
        public string Nome { get; set; } 
        
        public string Cognome { get; set; }
        
        public string DataNascita { get; set; }
 
        public string CodiceFiscale { get; set; }
        
        public string Sesso { get; set; }
       
        public string ComuneResidenza { get; set; }
        
        public int RedditoAnnuale { get; set; }

        public int ImposteVersate { get; set; }

        public Contribuente(string nome, string cognome, string dataNascita, string codiceFiscale, string sesso, string comuneResidenza, int redditoAnnuale, int imposteVersate)
        {
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
            CodiceFiscale = codiceFiscale;
            Sesso = sesso;
            ComuneResidenza = comuneResidenza;
            RedditoAnnuale = redditoAnnuale;
            ImposteVersate = imposteVersate;
        }

        public static int calcoloImposte (int redditoAnnuale)
        {   
            switch (redditoAnnuale)
            {
                case var n when redditoAnnuale <= 15000:
                    return (int) (n * 0.22);

                case var n when redditoAnnuale > 15000 && redditoAnnuale <= 50000:
                    return (int) (n * 0.30);
                
                case var n when redditoAnnuale > 50000:
                    return (int) (n  * 0.40);

                default:
                    return 0;
            }
        }

        public void presetati()
        {
            Console.WriteLine($"\n\n\nCiao sono {Nome} {Cognome}, sono nato il {DataNascita} a {ComuneResidenza}. \n\nINFORMAZIONI GENARLI: \nCodice fiscale: {CodiceFiscale},\nGenere: {Sesso},\nReddito annuale: {RedditoAnnuale},\nTasse: {ImposteVersate}");
        }
       
    }
}
