using WebApplication1.Models;

namespace WebApplication1.Repositry
{
    public interface IEmployeeRepo
    {
        IEnumerable<EmployeeDeptDto> GetEmployees();

        Employee GetEmployeeByid(int id);
        int AddEmployee(Employee employee);
        int UpdateEmployee(Employee employee);
        int DeleteEmployee(int id);
    }
}
