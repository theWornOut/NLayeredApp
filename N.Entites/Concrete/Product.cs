namespace N.Entites.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; }
        public short UnitsInStock { get; set; }
    }
}