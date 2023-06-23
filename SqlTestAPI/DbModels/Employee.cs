using System;
using System.Collections.Generic;

namespace SqlTestAPI.DbModels;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public int JobId { get; set; }

    public decimal? Salary { get; set; }

    public DateTime BirthDate { get; set; }

    public DateTime HireDate { get; set; }

    public int? DepartmentId { get; set; }

    public int? ManagerId { get; set; }

    public string Phone { get; set; } = null!;

    public string StreetAddress { get; set; } = null!;

    public string City { get; set; } = null!;

    public string? StateProvince { get; set; }

    public string? PostalCode { get; set; }

    public int CountryId { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual Department? Department { get; set; }

    public virtual ICollection<Employee> InverseManager { get; set; } = new List<Employee>();

    public virtual Job Job { get; set; } = null!;

    public virtual Employee? Manager { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
