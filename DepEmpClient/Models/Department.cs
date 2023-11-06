using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace DepEmpClient.Models
{
    public class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }
        [JsonPropertyName("departmentId")]
        public int DepartmentId { get; set; }
        [JsonPropertyName("departmentName")]
        public string DepartmentName { get; set; }
        public int TotalSalary { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
