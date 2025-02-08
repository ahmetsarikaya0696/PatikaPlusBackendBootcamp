using Microsoft.AspNetCore.Mvc;
using Pratik41.Models;

namespace Pratik41.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            Customer exampleCustomer = new Customer()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john@doe.com"
            };

            List<Order> exampleOrders = new List<Order>()
            {
                new Order()
                {
                    Id = 1,
                    ProductName = "Product 1",
                    Price = 10.0m,
                    Quantity = 2
                },
                new Order()
                {
                    Id = 2,
                    ProductName = "Product 2",
                    Price = 20.0m,
                    Quantity = 1
                }
            };

            CustomerOrderViewModel customerOrderViewModel = new CustomerOrderViewModel()
            {
                Customer = exampleCustomer,
                Orders = exampleOrders
            };

            return View(customerOrderViewModel);
        }
    }
}
