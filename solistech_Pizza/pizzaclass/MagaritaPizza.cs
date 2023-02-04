using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solistech_Pizza.pizzaclass
{
    internal class MagaritaPizza : Pizza
    {

        public MagaritaPizza() : base()
        {

        }

        public override List<string> GetIngredients()
        {
            List<string> ingredients = base.GetIngredients();
            ingredients.Add("cheese");
            ingredients.Add("Tomato");

            return ingredients;
        }
    }
}
