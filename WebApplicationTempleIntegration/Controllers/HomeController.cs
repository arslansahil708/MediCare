using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplicationTempleIntegration.Models;

namespace WebApplicationTempleIntegration.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDBContext db;
        public HomeController(AppDBContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }


        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Departments()
        {
            return View();
        }

        public IActionResult Doctors()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public AppDBContext GetDb1()
        {
            return db;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(Contact cto)
        {
            if (ModelState.IsValid)
            {


                db.contacts.Add(cto);
                db.SaveChanges();

                return RedirectToAction("Contact");
            }

            return View(cto);

        }

        [HttpPost]
        public IActionResult App(App app1)
        {
            if (ModelState.IsValid)
            {
                db.Apps.Add(app1);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View("Index", app1);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)] 
             IActionResult Error() 
            { return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }); }
        }
    }
