
using System.Security.Cryptography.X509Certificates;

public static class Arguments
{

    private static Int32 s_n = 0;
    
    //These are Parameters
    private static void M(Int32 x = 9, String s = "A", DateTime dt = default(DateTime), Guid guid = new Guid())
    {
        Console.WriteLine("x={0}, s={1}, dt={2}, guid={3}", x, s, dt, guid);
    }

    public static void Main()
    {

        //This should call the default values, so 9,A, CT, 0'd guid
        //Great example of values being 0'd out on instantiation 
        M();

        //Thhis should force x = 8, s"X"--> time should be still 0d
        M(8, "X");
        //Here we're naming  dt and guid -- named: arguments if it helps you remember

        //These are Arguments -- per our gods at Stack Overflow, "args are actual"
        M(5, guid: Guid.NewGuid(), dt: DateTime.Now);

        //this is a static variable set at 0. What does this look like in the CLR; what will happen here?
        //The book has this value at 2, I think it's actually at 1
        M(s_n++, s_n++.ToString());

        //this should set s first. S is 2 at this point, so s = 3, x = 4 or 4,3 right?

        M(s: (s_n++).ToString(), x: s_n++);
        
        //compiler doesn't necessarily read it that way
        
        
    }
}
