using System;
using System.Collections.Generic;

namespace SqlTestAPI.DbModels;

public partial class Inventory
{
    public int ProductId { get; set; }

    public int WarehouseId { get; set; }

    public int QuantityOnHand { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual Warehouse Warehouse { get; set; } = null!;
}
