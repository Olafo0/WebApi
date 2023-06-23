using Microsoft.AspNetCore.Mvc;
using SqlTestAPI.DbModels;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly SampleDbContext _context;

        public EmployeesController(SampleDbContext _context)
        {
            this._context = _context;
        }
        [HttpGet]
        public IActionResult GetEmployee()
        {

            var employees = _context.Employees.ToList();


            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult GetIdData(int id)
        {
            var employee = _context.Employees.SingleOrDefault(x => x.EmployeeId == id); // SingleOrDefualt - returns or if its not found it returns null

            return Ok(employee);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {

            var emp = _context.Employees.Where(x =>x.ManagerId == id).ToList();

            foreach (var e in emp)
            {
                e.ManagerId = 100;
            }

            var employee = _context.Employees.Single(x => x.EmployeeId == id);
            _context.Employees.Remove(employee);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPut("NationalPayrise")]
        public IActionResult NationalPayrise()
        {


            var pay = _context.Employees.Where(x => x.Salary > 0).ToList();

            foreach (var e in pay)
            {
                e.Salary = e.Salary * 1.04M;
            }
            _context.SaveChanges();

            return Ok();
        }


        [HttpPut("Name")]
        public IActionResult Changename(ChangeName changeName)
        {

            var e = _context.Employees.Single(x => x.EmployeeId == changeName.Id);
            e.FirstName = changeName.FirstName;
            e.MiddleName = changeName.MiddleName;
            e.LastName = changeName.LastName;
            _context.SaveChanges();

            return Ok();
        }


        [HttpPost]
        public IActionResult NewEmployee(CreateNewEmployee createnewemployee)
        {

            Employee newEmployee = new Employee() // Creating the the object 
            {
                // Getting the input from the json and assigning it to a variable
                FirstName = createnewemployee.FirstName,
                MiddleName = createnewemployee.MiddleName,
                LastName = createnewemployee.LastName,
                BirthDate = createnewemployee.BirthDate.Date,
                HireDate = createnewemployee.HireDate,
                DepartmentId = createnewemployee.DepartmentId,
                Salary = createnewemployee.Salary,
                ManagerId = createnewemployee.ManagerId,
                Phone = createnewemployee.Phone,
                StreetAddress = createnewemployee.StreetAddress,
                City = createnewemployee.City,
                StateProvince = createnewemployee.StateProvince,
                PostalCode = createnewemployee.PostalCode,
                CountryId = createnewemployee.CountryId,
                JobId = createnewemployee.JobId,

            };

            // Inserting the obj to a new row
            _context.Employees.Add(newEmployee);
            _context.SaveChanges();



            return Ok();
        }
    }
}
