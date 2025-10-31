using Microsoft.AspNetCore.Mvc;
using MyMVC8.Models;
using System.Diagnostics;

namespace MyMVC8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            List<Film> model = _context.Films.ToList();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult OneFilm()

        {

            Film model = _context.Films.FirstOrDefault();

            return View(model);

        }

        [HttpGet]
        public IActionResult FilmDetails(int id)
        {
            //List<Film> model = _context.Films.Find(FilmID);
            Film model = _context.Films.Find(id);
            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}