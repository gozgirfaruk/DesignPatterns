namespace CQRSDesign.CQRS.Results
{
    public class GetProductByIdQueryResult
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Strock { get; set; }
        public decimal Price { get; set; }
    }
}
