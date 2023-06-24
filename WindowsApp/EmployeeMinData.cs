using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp
{
    public class EmployeeMinData
    {
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public string Phone { get; set; } = null!;

        public string StreetAddress { get; set; } = null!;
        public int CountryId { get; set; }
    }
}
