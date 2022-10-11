namespace Session_6.Examples.Reusable;

#region framework

public abstract class Shop
{
    private CustList _customerList = new();

    public void CalculateSaleTax()
    {
        Console.WriteLine("Calculate Sales Tax");
    }

    public abstract string[] GetInventory();

    public abstract void BuyInventory(string item);
}

public interface INameable
{
    public string GetName();
    public void SetName(string name);
}

public class CustList
{
    private readonly List<string> _names = new();

    public string? FindCust(string name)
    {
        return _names.Find(n => n == name);
    }

    public void AddCust(string name)
    {
        _names.Add(name);
    }
}

#endregion

#region PizzaShop

public class ReusablePizzaShop : Shop, INameable
{
    private string _companyName = "";

    private readonly string[]
        _foodOfferings =
        {
            "Pizza",
            "Spaghetti",
            "Garden Salad",
            "Antipasto",
            "Calzone"
        };

    public override string[] GetInventory()
    {
        return _foodOfferings;
    }

    public override void BuyInventory(string item)
    {
        Console.WriteLine("\nYou have just purchased " + item);
    }

    public string GetName()
    {
        return _companyName;
    }

    public void SetName(string name)
    {
        _companyName = name;
    }
}

#endregion

#region DonutShop

public class ReusableDonutShop : Shop, INameable
{
    private string _companyName = "";

    private readonly string[]
        _menuItems =
        {
            "Donuts",
            "Muffins",
            "Danish",
            "Coffee",
            "Tea"
        };

    public override string[] GetInventory()
    {
        return _menuItems;
    }

    public override void BuyInventory(string item)
    {
        Console.WriteLine("\nYou have just purchased " + item);
    }

    public string GetName()
    {
        return _companyName;
    }

    public void SetName(string name)
    {
        _companyName = name;
    }
}

#endregion