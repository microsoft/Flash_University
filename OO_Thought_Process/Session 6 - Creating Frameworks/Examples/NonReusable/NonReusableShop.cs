namespace Session_6.Examples.NonReusable;


#region PizzaShop

public class PizzaShop
{
    private readonly string[]
        _foodOfferings =
        {
            "Pizza",
            "Spaghetti",
            "Garden Salad",
            "Antipasto",
            "Calzone"
        };

    public string[] GetInventory()
    {
        return _foodOfferings;
    }

    public void BuyInventory(string item)
    {
        Console.WriteLine("\nYou have just purchased " + item);
    }
}

#endregion

#region DonutShop

public class DonutShop
{
    private readonly string[]
        _menuItems =
        {
            "Donuts",
            "Muffins",
            "Danish",
            "Coffee",
            "Tea"
        };

    public string[] GetInventory()
    {
        return _menuItems;
    }

    public void BuyInventory(string item)
    {
        Console.WriteLine("\nYou have just purchased " + item);
    }
}

#endregion