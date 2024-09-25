using WebApplication1.Models;

namespace WebApplication1.Repositry
{
    public interface IDeptRepo
    {
        IEnumerable<Dept> GetDept();

        Dept GetDeptByid(int Did);
        int AddDept(Dept dept);
        int UpdateDept(Dept dept);
        int DeleteDept(int Did);
    }
}
