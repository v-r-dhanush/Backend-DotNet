using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyDemoApp.Models;

namespace MyDemoApp.Controllers
{
    public class InformationController : Controller
    {
        private CompanyContext context;

        public InformationController(CompanyContext cc)
        {
            context = cc;
        }

        public IActionResult Index()
        {
            return View(context.Information.AsNoTracking());
            //return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Create(Information inform)
        {
            context.Add(inform);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
            //return View();
        }

        public async Task<IActionResult> Update(int id)
        {
            Information inform = await context.Information.Where(e => e.Id == id).FirstOrDefaultAsync();
            return View(inform);
        }

        [HttpPost]

        public async Task<IActionResult> Update(Information inform)
        {
            context.Update(inform);
            await context.SaveChangesAsync();
            return RedirectToAction("Index"); 
        }

        [HttpPost]

        public async Task<IActionResult> Delete(int id)
        {
            var inform = new Information() { Id = id };
            context.Remove(inform);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
