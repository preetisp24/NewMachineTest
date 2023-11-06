using DepEmpClient.Interface;
using DepEmpClient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DepEmpClient.Controllers
{
    public class DepController : Controller
    {
        IApiService _service;
        public DepController(IApiService service)
        {
            _service = service;
        }


        public IActionResult Index()
        {
            var DepData = _service.GetDepData();
            var EmpData = _service.GetEmpData();
            DepEmp de = new DepEmp();

            foreach (var department in DepData)
            {
                int totalSalary = EmpData
                    .Where(e => e.DepartmentId == department.DepartmentId)
                    .Sum(e => e.Salary);

                department.TotalSalary = totalSalary;
            }

            // Pass the departments to the view
            return View(DepData);
            
        }
    }
}
