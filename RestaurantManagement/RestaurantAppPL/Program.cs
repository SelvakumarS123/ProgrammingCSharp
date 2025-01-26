using RestaurantAppBL;

namespace RestaurantAppPL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Initialize Restaurant
                var dineIn = new DineIn("Tasty Treats", "Main Street", 3);

                // Add Menu Items
                dineIn.AddMenuItem("Burger", 8.00m);
                dineIn.AddMenuItem("Pizza", 12.50m);

                // Display Menu
                Console.WriteLine("Menu:");
                foreach (var item in dineIn.GetMenu())
                {
                    Console.WriteLine($"{item.Key}: {item.Value:C}");
                }

                // Place Orders
                dineIn.OrderFood("Burger", 2);
                dineIn.OrderFood("Pasta", 1); // This will throw an exception (not in menu)

                // Reserve and Free Tables
                int tableNumber = dineIn.ReserveTable();
                dineIn.FreeTable(tableNumber);

                dineIn.FreeTable(5); // This will throw an exception (table does not exist)
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unhandled Error: {ex.Message}");
            }

        }
    }
}
