Func<int, int, int> twoLine;


twoLine = StraightLine;
Console.WriteLine(twoLine(3, 4));

Func<int, int, int> singleLine = ManhattanDist;
Console.WriteLine(singleLine(3, 4));


Func<int, int, int> heuristic = (a, b) => twoLine(a, b) + singleLine(a, b);
Console.WriteLine(heuristic(3, 4));


static int StraightLine(int a, int b)
{
    return (int)Math.Sqrt(a * a + b * b);
}

static int ManhattanDist(int a, int b)
{
    return a + b;
}