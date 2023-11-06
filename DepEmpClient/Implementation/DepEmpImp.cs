using DepEmpClient.Interface;
using DepEmpClient.Models;
using System.Text.Json;

namespace DepEmpClient.Implementation
{
    public class DepEmpImp:IApiService
    {
        HttpClient client;
        string baseAddress;
        public DepEmpImp(IConfiguration config)
        {
            this.client = new HttpClient();
            baseAddress = config["apiAddress"];
            this.client.BaseAddress = new Uri(baseAddress);
        }

        public List<Department> GetDepData()
        {

            var result = client.GetStringAsync(this.client.BaseAddress + "Departments").Result;
            List<Department> d = JsonSerializer.Deserialize<List<Department>>(result);
            return d;
        }

        public List<Employee> GetEmpData()
        {
            var result = client.GetStringAsync(this.client.BaseAddress + "employee").Result;
            List<Employee> emp = JsonSerializer.Deserialize<List<Employee>>(result);
            return emp;
        }
    }
}
