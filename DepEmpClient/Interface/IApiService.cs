using DepEmpClient.Models;

namespace DepEmpClient.Interface
{
    public interface IApiService
    {
        List<Department> GetDepData();
        List<Employee> GetEmpData();
    }
}
