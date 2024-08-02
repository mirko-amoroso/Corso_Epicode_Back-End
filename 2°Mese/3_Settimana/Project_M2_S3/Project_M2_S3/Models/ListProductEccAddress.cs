namespace Project_M2_S3.Models
{
    public class ListProductEccAddress
    {
        public List<ProductConListIngr> listaClasse {  get; set; }
        public string address {  get; set; }
        public string notes { get; set; }

        public bool done { get; set; } = false;
        public DateTime placedAt { get; set; }

    }
}
