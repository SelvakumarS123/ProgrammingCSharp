using RestaurantAppBL;

namespace RestaurantMnagementTests
{
    [TestClass]
    public sealed class RestaurantTests
    {
        [TestMethod]
        public void AddMenuItem_ValidItem_ShouldAddToMenu()
        {
            var restaurant = new Restaurant("Tasty Treats", "Main Street");
            restaurant.AddMenuItem("Pizza", 12.50m);

            var menu = restaurant.GetMenu();
            Assert.IsTrue(menu.ContainsKey("Pizza"));
            Assert.AreEqual(12.50m, menu["Pizza"]);
        }

        [TestMethod]
        public void AddMenuItem_InvalidPrice_ShouldHandleException()
        {
            var restaurant = new Restaurant("Tasty Treats", "Main Street");
            restaurant.AddMenuItem("Burger", -10m); // Invalid price

            var menu = restaurant.GetMenu();
            Assert.IsFalse(menu.ContainsKey("Burger"));
        }
        [TestMethod]
        public void OrderFood_ValidOrder_ShouldCalculateCost()
        {
            var restaurant = new Restaurant("Tasty Treats", "Main Street");
            restaurant.AddMenuItem("Pizza", 12.50m);

            var cost = restaurant.OrderFood("Pizza", 2);
            Assert.AreEqual(25.00m, cost);
        }

        [TestMethod]
        public void OrderFood_InvalidItem_ShouldReturnZero()
        {
            var restaurant = new Restaurant("Tasty Treats", "Main Street");
            restaurant.AddMenuItem("Pizza", 12.50m);

            var cost = restaurant.OrderFood("Burger", 1); // Invalid item
            Assert.AreEqual(0m, cost);
        }

        [TestMethod]
        public void DineIn_ReserveTable_ValidReservation_ShouldSucceed()
        {
            var dineIn = new DineIn("Tasty Treats", "Main Street", 3);
            int reservedTable = dineIn.ReserveTable();
            Assert.AreEqual(1, reservedTable); // First table reserved
        }

        [TestMethod]
        public void DineIn_ReserveTable_NoAvailableTable_ShouldReturnError()
        {
            var dineIn = new DineIn("Tasty Treats", "Main Street", 1);
            dineIn.ReserveTable();

            int secondReservation = dineIn.ReserveTable(); // No tables available
            Assert.AreEqual(-1, secondReservation); // Error case returns -1
        }

        [TestMethod]
        public void DineIn_FreeTable_ValidTable_ShouldSucceed()
        {
            var dineIn = new DineIn("Tasty Treats", "Main Street", 2);
            int reservedTable = dineIn.ReserveTable();
            dineIn.FreeTable(reservedTable); // Free the reserved table
        }

        [TestMethod]
        public void DineIn_FreeTable_InvalidTable_ShouldHandleException()
        {
            var dineIn = new DineIn("Tasty Treats", "Main Street", 2);
            dineIn.FreeTable(5); // Invalid table number
        }

        [TestMethod]
        public void TakeAway_OrderFood_ValidOrder_ShouldSucceed()
        {
            var takeAway = new TakeAway("Fast Bites", "Downtown");
            takeAway.AddMenuItem("Pasta", 15.00m);

            var cost = takeAway.OrderFood("Pasta", 3);
            Assert.AreEqual(45.00m, cost);
        }

        [TestMethod]
        public void TakeAway_OrderFood_InvalidQuantity_ShouldHandleException()
        {
            var takeAway = new TakeAway("Fast Bites", "Downtown");
            takeAway.AddMenuItem("Burger", 10.00m);

            var cost = takeAway.OrderFood("Burger", -2); // Invalid quantity
            Assert.AreEqual(0m, cost); // Order not processed
        }

        [TestMethod]
        public void GetMenu_EmptyMenu_ShouldHandleException()
        {
            var restaurant = new Restaurant("Empty Kitchen", "Unknown");
            var menu = restaurant.GetMenu();
            Assert.AreEqual(0, menu.Count);
        }

    }
}

