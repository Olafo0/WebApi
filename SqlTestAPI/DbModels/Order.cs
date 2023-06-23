using System;
using System.Collections.Generic;

namespace SqlTestAPI.DbModels;

public partial class Order
{
    public int OrderId { get; set; }

    public int CustomerId { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime? ShippedDate { get; set; }

    public int ShipperId { get; set; }

    public decimal FreightCost { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Shipper Shipper { get; set; } = null!;
}
