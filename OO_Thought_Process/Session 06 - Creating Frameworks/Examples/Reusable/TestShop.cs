namespace Session_6.Examples.Reusable;

internal class TestReusableShop
{
    public static void Run(Type shopType)
    {
        // create the shop
        Console.WriteLine("Creating the shop: " + shopType.Name);
        var shop = Activator.CreateInstance(shopType) as Shop;

        if (shop == null)
        {
            throw new Exception("shop type was not a valid shop");
        }

        RunShop(shop);
    }

    public static void RunShop(Shop shop)
    {
        // list the inventory
        var inventory = shop.GetInventory();

        for (var i = 0; i < inventory.Length; i++)
        {
            Console.WriteLine("Item " + i + " = " + inventory[i]);
        }

        // buy an item
        shop.BuyInventory(inventory[1]);
    }
}