using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using RevMVC.Models;
using System.Diagnostics;

namespace RevMVC.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult AboutRevansh()
    {
        return View();
    }

    public IActionResult Donations()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SetLanguage(string culture)
    {
        // Validate the culture string
        if (!string.IsNullOrEmpty(culture))
        {
            // Set the culture in a cookie
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddMonths(1) }
            );
        }

        // Redirect back to the referer URL to refresh the page with the new culture
        var referer = Request.Headers["Referer"].ToString();
        return Redirect(string.IsNullOrEmpty(referer) ? "~/" : referer);
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
