using Microsoft.AspNetCore.Mvc;
using MyNameSahil.Data;
using MyNameSahil.Models.Domain;
using MyNameSahil.Models;
using Microsoft.EntityFrameworkCore;

namespace MyNameSahil.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly MVCDemoDbcontext mvcDemoDbcontext;
        public EmployeesController(MVCDemoDbcontext mvcDemoDbcontext)
        {
            this.mvcDemoDbcontext = mvcDemoDbcontext;


        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var employees = await mvcDemoDbcontext.Employees.ToListAsync();
          return View(employees);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeViewModel addEmployeeRequest)
        {
            var employee = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = addEmployeeRequest.Name,
                Email = addEmployeeRequest.Email,
                Salary = addEmployeeRequest.Salary,
                Department = addEmployeeRequest.Department,
                DateOfBirth = addEmployeeRequest.DateOfBirth,
            };

           await mvcDemoDbcontext.Employees.AddAsync(employee);
           await mvcDemoDbcontext.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}
