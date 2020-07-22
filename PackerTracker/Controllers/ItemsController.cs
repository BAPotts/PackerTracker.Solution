using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;

namespace PackerTracker.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string name, int weight, bool packed)
    {
      Item myItem = new Item(name, weight, packed);
      return RedirectToAction("Index");
    }
  }
}