SomeMethod1();

void SomeMethod1()
{
    int x = 1, y = 2;
    IComparable c = x;

    //comparing c to y, c is Icomparable --> Object. so y will be boxed (object) y
    c.CompareTo(y);

    // 2 gets boxed to obj, will it work? --> string and int aren't comparable
    c.CompareTo("2");
}

void SomeMethod2()
{
    int x = 1, y = 2;
    IComparable<int> c = x;
    c.CompareTo(y);
    //c.CompareTo("2");//we know at compile time that it can't be boxed into another type
}