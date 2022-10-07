using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Task_004.Models;
using Task_004.ViewModels;

namespace Task_004.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        [Route("")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Author> objAuthorList = await _db.Authors.Include(x => x.Books).ToListAsync();
            return View(objAuthorList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Author author)
        {
            _db.Authors.Add(author);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Author? author = await _db.Authors.FirstOrDefaultAsync(x => x.Id == id);
                return View(author);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Author author)
        {
            _db.Authors.Update(author);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Author? author = await _db.Authors.FirstOrDefaultAsync(x => x.Id == id);
                if (author != null)
                {
                    _db.Authors.Remove(author);
                    await _db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Author? author = await _db.Authors.Include(x => x.Books).FirstOrDefaultAsync(x => x.Id == id);
                return View(author);
            }
            return NotFound();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}