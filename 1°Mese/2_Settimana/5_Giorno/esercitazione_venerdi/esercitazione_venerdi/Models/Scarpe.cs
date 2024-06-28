using System.ComponentModel.DataAnnotations;

namespace esercitazione_venerdi.Models
{
    public class Scarpe
    {
        [Display (Name = "ID")]
        public int  Id { get; set; }
        [Display(Name = "Nome")]
        public  string Name { get; set; }
        [Display(Name = "Descrizione")]
        public  string Description { get; set; }
        [Display (Name="Prezzo")]
        public double Prize { get; set; }
        [Display(Name = "immagine 1")]
        public IFormFile img_1 { get; set; }
        [Display(Name = "immagine 2")]
        public IFormFile? img_2 { get; set; }
        [Display(Name = "immagine 3")]
        public IFormFile? img_3 { get; set; }
        public string path { get; set; }
        public string path_2 { get; set; }
        public string path_3 { get; set; }

    }
}
