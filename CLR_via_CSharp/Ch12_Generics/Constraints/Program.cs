static bool MethodTakingAnyType<T>(T o)
{
    var temp = o;
    Console.WriteLine(o.ToString());
    var b = temp.Equals(o);
    return b;
}

// --3-- why does this throw an error ?
//static void CallMin()
//{
//    Object o1 = "Jeff", o2 = "Richter";
//    Object oMin = Min<Object>(o1, o2);
//}

//Why does this throw compiler errors? --1--


//static T Min<T>(T o1, T o2)
//{
//    if (o1.CompareTo(o2) < 0) return o1;
//    return o2;
//}

//How about this one? --2--
static T Min<T>(T o1, T o2) where T : IComparable<T>
{
    if (o1.CompareTo(o2) < 0) return o1;
    return o2;
}