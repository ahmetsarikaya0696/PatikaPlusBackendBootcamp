namespace Pratik41.Models
{
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; } = default!;
        public List<Order> Orders { get; set; } = default!;
    }
}
