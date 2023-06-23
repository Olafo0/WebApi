using System;
using System.Collections.Generic;

namespace SqlTestAPI.DbModels;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int CategoryId { get; set; }

    public decimal ListPrice { get; set; }

    public bool Discontinued { get; set; }

    public virtual ProductCategory Category { get; set; } = null!;

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
