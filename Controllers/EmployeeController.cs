using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyDemoApp.Models;

namespace MyDemoApp.Controllers
{
    public class EmployeeController : Controller
    {
        private CompanyContext context;
        public EmployeeController(CompanyContext cc)
        {
            context = cc;
        }
        //public IActionResult Index()
        //{
        //    return View(context.Employee.Include(s=>s.Department));
        //}

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(int id, string name)
        {
            string message = $"Welcome to the Page Mr.{name} your Employee id :{id}!!!";
            return View((object)message);
        }


        public IActionResult Create()
        {
            List<SelectListItem> dept = new List<SelectListItem>();
            dept = context.Department.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToList();
            ViewBag.Department = dept;
            return View();
        }

        [HttpPost]
        //[ActionName("Create")]

        public async Task<IActionResult> Create(Employee emp)
        {
            context.Add(emp);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Update(int id)
        {
            Employee emp = await context.Employee.Where(e => e.Id == id).FirstOrDefaultAsync();
            var Department = await context.Department.ToListAsync();
            ViewBag.Department = new SelectList(Department, "Id", "Name");
            return View(emp);
        }
        [HttpPost]
        public async Task<ActionResult> Update(Employee emp)
        {
            context.Update(emp);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpPost]

        public async Task<IActionResult> Delete(int id)
        {
            var emp = new Employee() { Id = id };
            context.Remove(emp); 
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
