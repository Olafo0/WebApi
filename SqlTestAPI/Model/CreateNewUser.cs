public class CreateNewEmployee
{

    public string FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string LastName { get; set; }

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
}