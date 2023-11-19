using Microsoft.AspNetCore.Mvc;
using MVCIntroDemo.Models.Product;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MVCIntroDemo.Controllers
{
    public class ProductController : Controller
    {
        private IEnumerable<ProductViewModel> _products=new List<ProductViewModel>()
        {
            new ProductViewModel()
            {
                Id = 1,
                Name="Cheese",
                Price=7.00
            }, new ProductViewModel()
            {
                Id=2,
                Name="Ham",
                Price=5.50
            },new ProductViewModel()
            {
                Id=3, Name="Brad",Price=1.50
            }

        };
        public IActionResult All()
        {
            return View(_products);
        }
        public IActionResult ById(int id)
        {
            ProductViewModel productViewModel = _products.First(x => x.Id == id);
            if (productViewModel==null)
            {
                return BadRequest();
            }
            return View(productViewModel);
        }
        public IActionResult AllAsJson()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
            return Json(_products ,options);

        }
        public IActionResult AllAsText()
        {
            var text = string.Empty;
            foreach (var item in _products)
            {
                text += $"Product:{item.Id} {item.Name} {item.Price}";
                text += "\r\n";
            }
            return Content(text);
        }
    }
}
