using Microsoft.AspNetCore.Mvc;
using signalRd1.Models;
using System.Linq;
namespace signalRd1.Controllers
{
    public class EmployeeController : Controller
    {
        context db;
        public EmployeeController(context db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var employees=db.Employees.ToList();
            return View(employees);
        }

        public IActionResult add()
        {
            return View();
        }
    }
}
