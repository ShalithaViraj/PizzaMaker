using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solistech_Pizza.pizzaclass
{
    internal class Pizza
    {
        private List<string> ingredients;

        public Pizza()
        {
            ingredients = new List<string>();
        }

        public virtual List<string> GetIngredients()
        {
            return ingredients;
        }

        public virtual void SetIngredients(List<string> ingredients)
        {
            this.ingredients = ingredients;
        }
        
        public virtual void MakePizzaDought(String weatflours, String yeast)
        {
            
        }
    }
}
