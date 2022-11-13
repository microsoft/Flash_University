Int32 x;
//Console.WriteLine(x);
ChangeValueByOut(out x);
Console.WriteLine(x);
ChangeValByValue( x);
Console.WriteLine(x);
ChangeValueByRef(ref x);
Console.WriteLine(x);



static void ChangeValueByOut(out Int32 k)
{
    k = 10;
}

static void ChangeValByValue(Int32 k)
{
    k = 5;
}
static void ChangeValueByRef(ref Int32 k)
{
    k = 20;
}