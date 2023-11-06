using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DepEmpClient.Models
{
    public class Employee
    {
        [JsonPropertyName("employeeId")]
        public int EmployeeId { get; set; }
        [JsonPropertyName("employeeName")]
        public string EmployeeName { get; set; }
        [JsonPropertyName("salary")]
        public int Salary { get; set; }
        [JsonPropertyName("departmentId")]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public int TotalSalary { get; set; }

        public virtual Department Department { get; set; }
    }
}
