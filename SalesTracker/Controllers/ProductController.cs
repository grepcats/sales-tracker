using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SalesTracker.Models;
using Microsoft.AspNetCore.Identity;

namespace SalesTracker.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProductController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public IActionResult Index()
        {
            var model = _db.Products.ToList();
            return View(model);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Manager")]
        public IActionResult Delete(int id)
        {
            var thisProduct = _db.Products.FirstOrDefault(Products => Products.ProductId == id);
            return View(thisProduct);
        }

        [Authorize(Roles = "Manager")]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisProduct = _db.Products.FirstOrDefault(Products => Products.ProductId == id);
            _db.Products.Remove(thisProduct);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
