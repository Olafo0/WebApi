using System;
using System.Collections.Generic;

namespace SqlTestAPI.DbModels;

public partial class Warehouse
{
    public int WarehouseId { get; set; }

    public string? WarehouseName { get; set; }

    public int? LocationId { get; set; }

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual Location? Location { get; set; }
}
