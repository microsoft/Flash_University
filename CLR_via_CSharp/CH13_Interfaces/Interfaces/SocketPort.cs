namespace Interfaces;

internal class SocketPort : ISend, IReceive
{
    public void ReceiveData()
    {
        Console.WriteLine("Receiving Data");
    }

    public void TransmitData()
    {
        Console.WriteLine("Sending Data");
    }
}