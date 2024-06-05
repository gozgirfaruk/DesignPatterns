namespace CQRSDesign.CQRS.Commands
{
    public class DeleteProductCommand
    {
        public int ProductID { get; set; }

        public DeleteProductCommand(int productID)
        {
            ProductID = productID;
        }
    }
}
