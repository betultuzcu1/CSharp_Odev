namespace MVC_MyProject.Models.CartModel
{
    public class CartItem
    {
        public CartItem()
        {
            Quantity = 1;
        }
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public short Quantity { get; set; }

        public decimal? SubTotal
        {
            get
            {
                return Quantity * UnitPrice;
            }
        }
    }
}
