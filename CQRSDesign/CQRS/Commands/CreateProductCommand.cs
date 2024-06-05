namespace CQRSDesign.CQRS.Commands
{
    public class CreateProductCommand
    {
        public string Name { get; set; }
        public int Strock { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
