using Microsoft.EntityFrameworkCore;
using Project_M2_S3.Context;
using Project_M2_S3.Interfacce;
using Project_M2_S3.Models;
using Project_M2_S3.Models.Entity;

namespace Project_M2_S3.Service
{
    public class Ingredienti : IIngredienti
    {
        private readonly DataContext DContext;
        public Ingredienti(DataContext context)
        {
            DContext = context;
        }

            public void Crea(Ingredient model)
            {
                DContext.Add(model);
                DContext.SaveChanges();
            }

        public async Task CreaAsync(Ingredient model)
        {
            DContext.Add(model);
            await DContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Ingrediente>> GetAll()
        {
            return await DContext.Ingredients
                                 .Select(i => new Ingrediente(i.Id, i.Name))
                                 .ToListAsync();
        }
    }
}

