﻿namespace Pratik41.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = default!;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
