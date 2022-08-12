namespace Session_6.Examples.NonReusable;

internal class TestNonReusableShop
{
    public static void Run()
    {
        RunPizzaShop();
        Console.WriteLine();
        RunDonutShop();
    }

    public static void RunPizzaShop()
    {
        Console.WriteLine("Creating the Pizza shop");
        var pizzaShop = new PizzaShop();

        // list the inventory
        var inventory = pizzaShop.GetInventory();

        for (var i = 0; i < inventory.Length; i++)
        {
            Console.WriteLine("Item " + i + " = " + inventory[i]);
        }

        // buy an item
        pizzaShop.BuyInventory(inventory[1]);
    }

    public static void RunDonutShop()
    {
        Console.WriteLine("Creating the Donut shop");
        var donutShop = new DonutShop();

        // list the inventory
        var inventory = donutShop.GetInventory();

        for (var i = 0; i < inventory.Length; i++)
        {
            Console.WriteLine("Item " + i + " = " + inventory[i]);
        }

        // buy an item
        donutShop.BuyInventory(inventory[1]);
    }
}