using Microsoft.AspNetCore.Mvc;
using ParcelDelivery.Models;

namespace ParcelDelivery.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form()
    {
      return View();
    }
    [Route("/package-results")]
    public ActionResult PackageResults()
    {
      PackageVariable myPackageVariable = new PackageVariable();
      myPackageVariable.SetWeight(int.Parse(Request.Query["weight"]));
      myPackageVariable.SetSpeed(int.Parse(Request.Query["speed"]));
      return View(myPackageVariable);
    }
  }
}
