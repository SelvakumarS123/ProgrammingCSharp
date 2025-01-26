namespace RestaurantAppBL
{
    public class Restaurant
    {
        public string Name { get; private set; }
        public string Location { get; private set; }
        protected Dictionary<string, decimal> Menu { get; set; } = new();

        public Restaurant(string name, string location)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(location))
                throw new ArgumentException("Restaurant name and location cannot be empty.");

            Name = name;
            Location = location;
        }

        public void AddMenuItem(string itemName, decimal price)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(itemName))
                    throw new ArgumentException("Menu item name cannot be empty.");

                if (price <= 0)
                    throw new ArgumentException("Price must be greater than zero.");

                Menu[itemName] = price;
                Console.WriteLine($"{itemName} added to the menu at {price:C}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding menu item: {ex.Message}");
            }
        }

        public virtual decimal OrderFood(string foodItem, int quantity)
        {
            try
            {
                if (quantity <= 0)
                    throw new ArgumentException("Quantity must be greater than zero.");

                if (!Menu.ContainsKey(foodItem))
                    throw new ArgumentException($"{foodItem} is not available on the menu.");

                decimal totalCost = Menu[foodItem] * quantity;
                Console.WriteLine($"Order placed: {quantity} x {foodItem} = {totalCost:C}");
                return totalCost;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing order: {ex.Message}");
                return 0;
            }
        }

        public Dictionary<string, decimal> GetMenu()
        {
            try
            {
                if (Menu.Count == 0)
                    throw new InvalidOperationException("The menu is empty.");

                return new Dictionary<string, decimal>(Menu);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving menu: {ex.Message}");
                return new Dictionary<string, decimal>();
            }
        }
        
    }

}
