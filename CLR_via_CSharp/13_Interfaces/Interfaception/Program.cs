var spinning = new SpinningTop();
Console.WriteLine("How many dreams?");

internal interface IOne
{
    void MethodOne();
}

internal interface ITwo : IOne
{
    void MethodTwo();
    // what if we name this to method One?
    // Lets try letting Visual studio handle it and see what happens
}

internal class SpinningTop : ITwo
{
    public void MethodOne()
    {
        throw new NotImplementedException();
    }

    public void MethodTwo()
    {
        throw new NotImplementedException();
    }
}