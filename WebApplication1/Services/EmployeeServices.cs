using WebApplication1.Models;
using WebApplication1.Repositry;

namespace WebApplication1.Services
{
    public class EmployeeServices : IEmployeeServices
    {
        private readonly IEmployeeRepo repo;
        public EmployeeServices(IEmployeeRepo repo)
        {
               this.repo = repo;
        }
        public int AddEmployee(Employee employee)
        {
            return repo.AddEmployee(employee);
        }

        public int DeleteEmployee(int id)
        {
            return repo.DeleteEmployee(id);
        }

        public Employee GetEmployeeByid(int id)
        {
            return repo.GetEmployeeByid(id);
        }

        public IEnumerable<EmployeeDeptDto> GetEmployees()
        {
            return repo.GetEmployees();
        }

        public int UpdateEmployee(Employee employee)
        {
            return repo.UpdateEmployee(employee);
        }
    }
}
