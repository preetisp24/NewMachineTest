using Microsoft.Build.Graph;

namespace DepEmpClient.Models
{
    public class DepEmp
    {
        public Department Dep{ get; set; }
        public Employee Emp { get; set; }

      
        public int TotalSalarybydepartment { get; set; }
        public int TotalSalary { get; set; }

    }
}
