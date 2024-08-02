namespace Project_M2_S3.Models
{
    public class Ingrediente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSelected { get; set; }


        public Ingrediente()
        {
        }
        public Ingrediente(int id, string nome)
        {
            Id = id;
            Name = nome;
            IsSelected = false;
        }
    }
}

