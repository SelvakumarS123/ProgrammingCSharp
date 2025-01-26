using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAppBL
{
    public class TakeAway : Restaurant
    {
        public TakeAway(string name, string location) : base(name, location)
        {

        }

        public override decimal OrderFood(string foodItem, int quantity)
        {
            try
            {
                return base.OrderFood(foodItem, quantity); // No additional charge for take-away
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing take-away order: {ex.Message}");
                return 0;
            }
        }

    }
}
