using NuGet.Packaging.Signing;
using WebApplication1.Models;
using WebApplication1.Repositry;

namespace WebApplication1.Services
{
    public class DeptServices : IDeptServices
    {
        private readonly IDeptRepo repo;
        public DeptServices(IDeptRepo repo)
        {
            this.repo = repo;
        }

        public int AddDept(Dept dept)
        {
            return repo.AddDept(dept);  
        }

        public int DeleteDept(int Did)
        {
            return repo.DeleteDept(Did);
        }

        public IEnumerable<Dept> GetDept()
        {
            return repo.GetDept();
        }

        public Dept GetDeptByid(int Did)
        {
            return repo.GetDeptByid(Did);
        }

        public int UpdateDept(Dept dept)
        {
           return repo.UpdateDept(dept);
        }
    }
}
