using System.Threading.Tasks.Dataflow;

Console.WriteLine(1+1);

Apple apple1 = new Apple(2);
Apple apple2 = new Apple(3);

Apple apple3 = apple1 + apple2;
Console.WriteLine(apple3);

//they say you can't add apples and oranges but, well, Jeff can
//Apple orange = new Orange(5);
//Console.WriteLine(orange + apple3);

class Apple
{
    int _bushels = 0;

    internal Apple(int i)
    {
        _bushels = i;
    }

    public static Apple operator +(Apple apple1, Apple apple2)
    {
        return new Apple(apple1._bushels + apple2._bushels);
    }

    public override string ToString()
    {
        return _bushels.ToString();
    }
}

//class Orange : Apple
//{
//    int _bushels = 0;
//    internal Orange(int i) : base(i)
//    {
//        _bushels = i;
//    }
//}