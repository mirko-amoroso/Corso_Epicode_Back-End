using Microsoft.AspNetCore.Mvc;
using Project_M2_S3.Models.Entity;
using Project_M2_S3.Models;

namespace Project_M2_S3.Interfacce
{
    public interface IPizze
    {
        public void Create(Product model);

        public IEnumerable<ProductConListIngr> GetAll();
    }
}
