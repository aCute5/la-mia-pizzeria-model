using Microsoft.AspNetCore.Mvc;
using la_mia_pizzeria_static.Models;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            using var ctx = new PizzaContext();
            var pizzas = ctx.Pizze.ToArray();

            return View(pizzas);

        }
        public IActionResult Detail(int id)
        {
            using var ctx = new PizzaContext();
            var pizza = ctx.Pizze.SingleOrDefault(p => p.Id == id);

            if (pizza is null)
            {
                return NotFound($"Pizza with id {id} not found.");
            }

            return View(pizza);
        }
    }

}