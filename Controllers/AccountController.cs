using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using aviato.Models;
using aviato.Models.DB;

namespace aviato.Controllers
{
    public class AccountController : Controller
    {
        
    private readonly AVIATOContext _context;

    public AccountController(ILogger<AccountController> logger , AVIATOContext context)
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
    
    [HttpPost]

    public IActionResult Login(Register register)
    {
        var Register = _context.Registers.FirstOrDefault(u => u.Email == register.Email && u.Password == register.Password);
        if (Register != null)
        {
            HttpContext.Session.SetInt32("id", Register.Id);
            HttpContext.Session.SetString("fullname", Register.Ad);
            return Redirect("/Home");
        }
        else
        {
            ViewBag.Message = " Kullanıcı adı veya şifre hatalı!";
            return View();
        }
    }
       
    public async Task<IActionResult> Register(Register a)
    {
        await _context.AddAsync(a);
        await _context.SaveChangesAsync();
        return View();    
    }
    [HttpPost] 
    public ActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("/Home");
    }
    public ActionResult signUp()
    {
        return View();    
    }
  
       public IActionResult SifreUnuttum()
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
}
