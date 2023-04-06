using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<PizzaModel> pizze = new List<PizzaModel>
            {
                new PizzaModel("Margherita", "Mozzarella, Pomodoro", 5),
                new PizzaModel("Marinara", "Pomodoro, Origano", 3),
                new PizzaModel("Viennese","Pomodoro Mozzarella Wurstel", 6),

            };
            return View("Index", pizze);
        }
    }
}
