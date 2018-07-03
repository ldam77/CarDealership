using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
    public class NewCarController : Controller
    {

        [HttpGet("/new-car")]
        public ActionResult CarList()
        {
            NewCar newCar = new NewCar(Request.Query["new-make"], Request.Query["new-model"], Request.Query["new-color"], Request.Query["new-year"], Request.Query["new-price"]);
            newCar.Save();
            return View(NewCar.GetAll());
        }

        [HttpGet("/newcar/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
    }
}
