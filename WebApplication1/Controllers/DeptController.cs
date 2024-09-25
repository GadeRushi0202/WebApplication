using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class DeptController : Controller
    {
        private readonly IDeptServices services;
        public DeptController(IDeptServices services)
        {
            this.services = services;
        }

        // GET: DeptController
        public ActionResult Index()
        {
            return View(services.GetDept());
        }

        // GET: DeptController/Details/5
        public ActionResult Details(int id)
        {
            var model = services.GetDeptByid(id);   
            return View(model);
        }

        // GET: DeptController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeptController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Dept dept)
        {
            try
            {
                int result = services.AddDept(dept);
                if(result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: DeptController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = services.GetDeptByid(id);
            return View(model);
        }

        // POST: DeptController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Dept dept)
        {
            try
            {
                int result = services.UpdateDept(dept);
                if(result <= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: DeptController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DeptController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                var result = services.DeleteDept(id);   
                if(result <= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
                
            }
            catch
            {
                return View();
            }
        }
    }
}
