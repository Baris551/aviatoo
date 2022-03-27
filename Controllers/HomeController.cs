using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aviato.Models;
using aviato.Models.DB;

namespace aviato.Controllers
{

#nullable disable
public class HomeController : Controller
{
    

     AVIATOContext _context;

   public HomeController(ILogger<HomeController> logger, AVIATOContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var trend = _context.Products.OrderByDescending(i => i.Id).Take(8).ToList();
        return View(trend);
    }
    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult shop()
    {
        var allProducts = _context.Products.Where(p => p.Aktif == true);
        return View(allProducts);
    }
    public ActionResult shopdetail(int? id)
    {
         if (id == null)
            {
                return RedirectToAction("Index");
            }
    var selectedProduct = _context.Products.FirstOrDefault(p => p.Id == id);
        return View(selectedProduct);
    }
      public IActionResult About()
    {
        return View();
    }
      public IActionResult checkout()
    {
        return View();
    }
          public IActionResult contact()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
}