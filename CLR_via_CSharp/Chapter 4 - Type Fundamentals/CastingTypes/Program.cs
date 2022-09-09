//This is basically the program form page 93
Console.WriteLine("Hello, World!");

//note we aren't setting this as Employee e =; implicitly derived from Object
Object o = new Employee();
//cast operator. we are from object to a derived type. In the CLR, everything is "type safe" at run tim
//It is impossible to switch types at run time. See the difference between the two below. You can use based types implicitly above
// But can't go the other way around.

// Employee e = o;
//explicit casting
// Employee e = (Employee)o;


// We now have something that compiles. (basically can make sane IL code/assemblies etc.) It still might have a problem at run time (when it actually runs on the CLR)
// What are some possibilities?
internal class Employee{}

