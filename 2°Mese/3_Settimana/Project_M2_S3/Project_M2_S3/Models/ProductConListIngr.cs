using Project_M2_S3.Models.Entity;

namespace Project_M2_S3.Models
{
    public class ProductConListIngr : Product
    {
        public List<string> ingrediente { get; set; } = new List<string>();
        public int quantita { get; set; } = 0;
    }
}
