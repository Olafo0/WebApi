using System;
using System.Collections.Generic;

namespace SqlTestAPI.DbModels;

public partial class Location
{
    public int LocationId { get; set; }

    public string StreetAddress { get; set; } = null!;

    public string City { get; set; } = null!;

    public string? StateProvince { get; set; }

    public string? PostalCode { get; set; }

    public int CountryId { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<Warehouse> Warehouses { get; set; } = new List<Warehouse>();
}
