using Microsoft.AspNetCore.Mvc;
using PYP_DynamicPartialView.Models;

namespace PYP_DynamicPartialView.Controllers
{
    public class EmployeeController : Controller
    {
        List<Employee> employees = new List<Employee>
        {
          new Employee{ Id=1, Name="Orkhan", Position="Developer"},
          new Employee{Id=2,Name="Tebriz",Position="Malyar"},
          new Employee{Id=3, Name="Resul",Position="Santexnik"}
        };
        public IActionResult Index()
        {
            return View(employees);
        }
    }
}
