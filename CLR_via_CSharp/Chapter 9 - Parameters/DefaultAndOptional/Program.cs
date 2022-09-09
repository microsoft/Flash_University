using System.Runtime.InteropServices;

Test1();
Test2();


void Test1([Optional, DefaultParameterValue("param1")] string p1, [Optional, DefaultParameterValue("param2")] string p2)
{
    Console.WriteLine(p1 + " " + p2);
}
 void Test2(string p1 = "param1", string p2 = "param2")
 {
     Console.WriteLine(p1 + " " + p2);
}