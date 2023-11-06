using DepEmpClient.Interface;
using DepEmpClient.Models;
using Microsoft.AspNetCore.Mvc;

namespace DepEmpClient.Controllers
{
    public class DepEmpController : Controller
    {

        IApiService _service;
        public DepEmpController(IApiService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var DepData = _service.GetDepData();
            var EmpData = _service.GetEmpData();

      
            var sumOfSalariesByDepartmentAndEmployee = EmpData.GroupBy(s => new { s.DepartmentId, s.EmployeeName, s.Salary })
           .Select(g => new Employee()
           {
            DepartmentName = DepData.FirstOrDefault(d => d.DepartmentId == g.Key.DepartmentId)?.DepartmentName,
            EmployeeName = g.Key.EmployeeName,
            Salary = g.Key.Salary,
            TotalSalary = g.Sum(s => s.Salary)
           
           }).OrderBy(g => g.DepartmentName) 
           .ToList();


            var departmentTotals = EmpData
             .GroupBy(e => e.DepartmentId)
             .Select(g => new
             {
                 DepartmentId = g.Key,
                 TotalSalary = g.Sum(e => e.Salary)
             })
             .ToList();

            ViewBag.DepartmentTotals = departmentTotals;
            return View(sumOfSalariesByDepartmentAndEmployee);




        }
    }
}





//public IActionResult TotalSalaryOfAllDepartments()
//{
//    var DepData = _service.GetDepData();
//    var EmpData=_service.GetEmpData();
//    decimal totalSalary = 0;


//    //foreach (var department in DepData)
//    //{
//    //    var employees=EmpData.Where(e => e.DepartmentId == DepData)
//    //        .Select(e => e.Salary)
//    //        .ToList();



//    //    totalSalary += employees.Sum();
//    //}

//    return View();
//}


