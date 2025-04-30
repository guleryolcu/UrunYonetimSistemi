using Microsoft.AspNetCore.Mvc;
using UrunYonetimSistemi.Models;

namespace UrunYonetimSistemi.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Laptop", Price = 15000, Description = "Yüksek performanslı laptop" },
            new Product { Id = 2, Name = "Klavye", Price = 350, Description = "Mekanik klavye" }
        };

        public IActionResult Index() => View(_products);

        public IActionResult Details(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            return product == null ? NotFound() : View(product);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            return product == null ? NotFound() : View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product updated)
        {
            var product = _products.FirstOrDefault(p => p.Id == updated.Id);
            if (product == null) return NotFound();

            product.Name = updated.Name;
            product.Price = updated.Price;
            product.Description = updated.Description;
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            return product == null ? NotFound() : View(product);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null) _products.Remove(product);
            return RedirectToAction("Index");
        }
    }
}
