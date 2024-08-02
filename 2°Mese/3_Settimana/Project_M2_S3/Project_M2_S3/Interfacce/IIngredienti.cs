using Project_M2_S3.Models;
using Project_M2_S3.Models.Entity;

namespace Project_M2_S3.Interfacce
{
    public interface IIngredienti
    {
        public void Crea(Ingredient model);
        public Task<IEnumerable<Ingrediente>> GetAll();
    }
}
