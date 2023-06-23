using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp
{
    public class EmployeeData
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
    }
}
