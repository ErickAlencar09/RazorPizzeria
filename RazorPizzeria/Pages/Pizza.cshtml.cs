using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            
                new PizzasModel(){ImageTitle ="Margerita" , PizzaName = "Margerita", BasePrice = 2, Cheese=true, TomatoSauce=true, FinalPrice=4},
                new PizzasModel(){ImageTitle ="Hawaiian" , PizzaName = "Hawaiian", BasePrice = 2, Cheese=true, Tuna=true, FinalPrice=4},
                new PizzasModel(){ImageTitle ="Carbonara" , PizzaName = "Carbonara", BasePrice = 2, Cheese=true, Peperoni=true, FinalPrice=4},
                new PizzasModel(){ImageTitle ="Vegetarian" , PizzaName = "Vegetarian", BasePrice = 2, Cheese=true, Mushroom=true, FinalPrice=4},
        };
        public void OnGet()
        {
        }
    }
}
