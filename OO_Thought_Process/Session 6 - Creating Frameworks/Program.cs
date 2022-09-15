
using Session_6.Examples.NonReusable;
using Session_6.Examples.Reusable;

Console.WriteLine(" --- Running the non-reusable shop tests ---\n");

TestNonReusableShop.Run();
Console.WriteLine();

Console.WriteLine(" --- Running the non-reusable shop tests ---\n");


TestReusableShop.Run(typeof(ReusablePizzaShop));
Console.WriteLine();

TestReusableShop.Run(typeof(ReusableDonutShop));
