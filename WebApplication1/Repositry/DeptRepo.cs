using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Repositry
{
    public class DeptRepo : IDeptRepo
    {
        private readonly ApplicationDbContext db;
        public DeptRepo(ApplicationDbContext db)
        {
            this.db = db;
        }

        public int AddDept(Dept dept)
        {
            db.Depts.Add(dept);
            int result = db.SaveChanges();  
            return result;
        }

        public int DeleteDept(int Did)
        {
            int res = 0;
            var result = db.Depts.Where(d => d.Did == Did).FirstOrDefault();
            if (result != null)
            {
                db.Depts.Remove(result);
                res = db.SaveChanges();
            }
            return res;
        }

        public IEnumerable<Dept> GetDept()
        {
            var result = db.Depts.ToList();
            return result;
        }

        public Dept GetDeptByid(int Did)
        {
            var result = db.Depts.Where(d => d.Did == Did).FirstOrDefault();
            return result;
        }

        public int UpdateDept(Dept dept)
        {
            int res = 0;
            var result = db.Depts.Where(d => d.Did == dept.Did).FirstOrDefault();
            if (result != null)
            {
                result.Dname = dept.Dname;
            }
            return res;
        }
    }
}
