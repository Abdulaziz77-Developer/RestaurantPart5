using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPart5.Models
{
    public abstract class Drink :MenuItems
    {
        private string name = "No Drink";

        public string GetDrinkName
        {
            get
            {
                 return name;
            } 
        }
        public Drink(string _name)
        {
            this.name = _name;
        }
    }
}
