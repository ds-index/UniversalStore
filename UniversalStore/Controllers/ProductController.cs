using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversalStore.Data;
using UniversalStore.Models;

namespace UniversalStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProductController(ApplicationDbContext db) => _db = db;

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Product> products = await _db.Products.ToListAsync();
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (product is null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                await _db.Products.AddAsync(product);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index", "Product");
            }
            return View(product);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id is null || id == 0)
            {
                return NotFound();
            }
            var result = _db.Products.Find(id);

            if(result is null)
            {
                return NotFound();
            }
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if(product is null)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                _db.Products.Update(product);
                _db.SaveChanges();
                return RedirectToAction("Index", "Product");
            }
            return View(product);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id is null || id == 0)
            {
                return NotFound();
            }
            var result = _db.Products.Find(id);

            if (result is null)
            {
                return NotFound();
            }
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            if (product is null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Products.Remove(product);
                _db.SaveChanges();
                return RedirectToAction("Index", "Product");
            }
            return View(product);
        }
    }
}
