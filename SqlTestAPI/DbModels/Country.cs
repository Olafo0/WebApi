using System;
using System.Collections.Generic;

namespace SqlTestAPI.DbModels;

public partial class Country
{
    public int CountryId { get; set; }

    public string? CountryName { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
}
