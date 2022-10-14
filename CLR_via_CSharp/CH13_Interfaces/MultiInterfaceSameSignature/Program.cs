var pizza = new PizzaPlace();


//TODO Implement and then access all '3' -- Explicit understanding


public interface IWindow
{
    void GetMenu();
}

public interface IRestaurant
{
    void GetMenu();
}

public class PizzaPlace : IWindow, IRestaurant
{
    void IRestaurant.GetMenu()
    {
        Console.WriteLine("IRestaurant");
    }

    //public object GetMenu()
    //{
    //    Console.WriteLine("does this work?");
    //    return new Object();
    //}
    void IWindow.GetMenu()
    {
        Console.WriteLine("IWindow");
    }

    public void GetMenu()
    {
        Console.WriteLine("Get Menu");
    }
}