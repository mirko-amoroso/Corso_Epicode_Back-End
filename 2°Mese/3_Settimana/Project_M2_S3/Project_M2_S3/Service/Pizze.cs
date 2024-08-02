using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_M2_S3.Context;
using Project_M2_S3.Interfacce;
using Project_M2_S3.Models;
using Project_M2_S3.Models.Entity;

namespace Project_M2_S3.Service
{
    public class Pizze : IPizze
    {
        private readonly DataContext DContext;

        public Pizze(DataContext context)
        {
            DContext = context;
        }
        public void Create(Product model)
        {
            DContext.Add(model);
            DContext.SaveChanges();
        }

        public  IEnumerable<ProductConListIngr> GetAll()
        {
            var query = from prodotto in DContext.Products
                        join ingredienteProd in DContext.IngredientProduct
                            on prodotto.Id equals ingredienteProd.ProductsId
                        join ingrediente in DContext.Ingredients
                            on ingredienteProd.IngredientsId equals ingrediente.Id
                        select new
                        {
                            Prodotto = prodotto,
                            Ingrediente = ingrediente
                        };

            var result = query
                .GroupBy(x => new
                {
                    x.Prodotto.Id,
                    x.Prodotto.Name,
                    x.Prodotto.Price,
                    x.Prodotto.DeliveryTimeInMinutes,
                    x.Prodotto.Photo
                })
                .Select(g => new ProductConListIngr
                {
                    Id = g.Key.Id,
                    Name = g.Key.Name,
                    Photo = g.Key.Photo,
                    Price = g.Key.Price,
                    DeliveryTimeInMinutes = g.Key.DeliveryTimeInMinutes,
                    ingrediente = g.Select(x => x.Ingrediente.Name).ToList()
                })
                .ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }
            return result;
        }
    }
}
