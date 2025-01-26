using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAppBL
{
    public class DineIn : Restaurant
    {
        private Dictionary<int, bool> Tables { get; set; } = new();

        public DineIn(string name, string location, int tableCount) : base(name, location)
        {
            try
            {
                if (tableCount <= 0)
                    throw new ArgumentException("Table count must be greater than zero.");

                for (int i = 1; i <= tableCount; i++)
                {
                    Tables[i] = true; // All tables are initially free
                }

                Console.WriteLine($"{tableCount} tables initialized for dine-in service.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error initializing dine-in: {ex.Message}");
            }
        }

        public int ReserveTable()
        {
            try
            {
                foreach (var table in Tables)
                {
                    if (table.Value) // Check if the table is free
                    {
                        Tables[table.Key] = false; // Reserve the table
                        Console.WriteLine($"Table {table.Key} reserved.");
                        return table.Key;
                    }
                }
                throw new InvalidOperationException("No tables are available for reservation.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reserving table: {ex.Message}");
                return -1;
            }
        }

        public void FreeTable(int tableNumber)
        {
            try
            {
                if (!Tables.ContainsKey(tableNumber))
                    throw new ArgumentException($"Table {tableNumber} does not exist.");

                if (Tables[tableNumber])
                    throw new InvalidOperationException($"Table {tableNumber} is already free.");

                Tables[tableNumber] = true;
                Console.WriteLine($"Table {tableNumber} is now free.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error freeing table: {ex.Message}");
            }
        }

        public override decimal OrderFood(string foodItem, int quantity)
        {
            decimal totalCost = base.OrderFood(foodItem, quantity);
            decimal serviceCharge = totalCost * 0.10m;
            totalCost += serviceCharge;

            if (totalCost > 0)
                Console.WriteLine($"Service charge (10%): {serviceCharge:C}. Total: {totalCost:C}");

            return totalCost;
        }

    }
}
