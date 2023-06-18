﻿namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Category? Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public IList<ProductAttribute>? Attributes { get; set; }
    }
}
