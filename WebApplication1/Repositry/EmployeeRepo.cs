using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Repositry
{
    public class EmployeeRepo:IEmployeeRepo
    {
        private readonly ApplicationDbContext db;
        public EmployeeRepo(ApplicationDbContext db)
        {
            this.db = db;
        }

        public int AddEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            int result = db.SaveChanges();
            return result;
        }

        public int DeleteEmployee(int id)
        {
            int res = 0;
            var result = db.Employees.Where(e => e.id ==id).FirstOrDefault();
            if (result != null)
            {
                db.Employees.Remove(result);
                res = db.SaveChanges() ;    
            }
            return res;
        }

        public Employee GetEmployeeByid(int id)
        {
            var result = db.Employees.Where(e => e.id == id).FirstOrDefault();
            return result;
        }

        public IEnumerable<EmployeeDeptDto> GetEmployees()
        {
            var result = (from e in db.Employees
                          join d in db.Depts on e.Did equals d.Did
                          select new EmployeeDeptDto
                          {
                               id=e.id,
                               Name=e.Name,
                               Age=e.Age,
                               salary=e.salary,
                               Did=d.Did,
                               Dname=d.Dname
                          }).ToList();

            return result;
        }

        public int UpdateEmployee(Employee employee)
        {
            int res = 0;
            var result = db.Employees.Where(e => e.id == employee.id).FirstOrDefault();
            if(result != null)
            {
                result.Name = employee.Name;
                result.Age = employee.Age;
                result.salary = employee.salary;
                result.Did= employee.Did;   
                res= db.SaveChanges() ; 
            }
            return res;
        }
    }
}
