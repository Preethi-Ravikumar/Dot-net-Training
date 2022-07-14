using Microsoft.AspNetCore.Mvc;
using MVCFirstApp.Models;

namespace MVCFirstApp.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        [Route("Home")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("GetEmployee")]
        public IActionResult GetEmployee(EmployeeModel input)
        {
            List<EmployeeModel> employees = getEmployees(input);
            return View(employees);
        }
        private List<EmployeeModel> getEmployees(EmployeeModel input)
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();
            var emp1 = new EmployeeModel();
            emp1.Id = 1;
            emp1.Name = "aaa";
            emp1.City = "chennai";
            emp1.Email = "aaa@gmail.com";
            employees.Add(emp1);
            var emp2 = new EmployeeModel();
            emp2.Id = 2;
            emp2.Name = "bbb";
            emp2.City = "bangalore";
            emp2.Email = "bbb@gmail.com";
            employees.Add(emp2);
            if(input != null)
            {
                employees.Add(AddEmployee(input));
            }
            return employees;
        }
        private EmployeeModel AddEmployee(EmployeeModel input)
        {

            var emp = new EmployeeModel();
            emp.Id = input.Id;
            emp.Name = input.Name;
            emp.City = input.City;
            emp.Email = input.Email;    

            return emp;

        }

    }
}
