using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solistech_Pizza.pizzaclass
{
    internal class CheckenPizza : Pizza
    {

        public CheckenPizza() : base()
        {

        }

        public override List<string> GetIngredients()
        {
            List<string> ingredients = base.GetIngredients();
            ingredients.Add("Cheese");
            ingredients.Add("Tomato");
            ingredients.Add("Checken");
            ingredients.Add("Onions");

            return ingredients;
        }
    }
}
