using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aviato.Models;
using aviato.Models.DB;
namespace aviato.Controllers;
#nullable disable

public class ÜrünlerController : Controller
{
    private readonly AVIATOContext _context;

   public ÜrünlerController(ILogger<ÜrünlerController> logger , AVIATOContext context)
    {
        _context= context;
    }

    public IActionResult Index()
    {
        return View();
    }
       public IActionResult Giyim()
    {
        return View();
    }
       public IActionResult Login()
    {
        return View();
    }
       public IActionResult Register()
    {
        return View();
    }
      public IActionResult shop(string p)
    {
        var degerler = from d in _context.Products select d;
        if(!string.IsNullOrEmpty(p))
        {
            //işlem
            degerler= degerler.Where(m =>m.ProductName.Contains(p));    
        }
        return View(degerler.ToList());
        // var tümÜrünler = _context.Products.ToList();
        // return View(tümÜrünler);
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
      public IActionResult checkout()
    {
        return View();
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
