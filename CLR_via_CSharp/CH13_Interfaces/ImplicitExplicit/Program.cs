var st = new SimpleType();
st.Dispose();

//Why is this allowed?
IDisposable d = st;

st.Dispose();

d.Dispose();


internal sealed class SimpleType : IDisposable
{
    // THis is called an explicit interface method implementation or EIMI
    void IDisposable.Dispose()
    {
        Console.WriteLine("IDisposable dispose");
    }
    //public void Dispose() {Console.WriteLine("Dispose");}

    public void Dispose()
    {
        Console.WriteLine("public dispose");
    }
}