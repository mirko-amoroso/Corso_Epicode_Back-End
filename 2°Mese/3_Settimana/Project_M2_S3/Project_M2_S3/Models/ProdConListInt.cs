using Project_M2_S3.Models.Entity;

namespace Project_M2_S3.Models
{
    public class ProdConListInt: Product
    {
        public List<int> ingredient { get; set; } = new List<int>();
    }
}
