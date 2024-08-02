using Project_M2_S3.Models;

namespace Project_M2_S3.Interfacce
{
    public interface IOrder
    {
        public void Save(ListProductEccAddress Pizze, int User);
        public IEnumerable<Tutto> GetAll();
        public void Update(int id );
    }
}
