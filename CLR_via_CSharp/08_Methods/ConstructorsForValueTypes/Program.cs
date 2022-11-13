using System.Security.Cryptography.X509Certificates;



Rectangle oldRectangle;
Rectangle rectangle = new Rectangle();
OtherRectangle otherRectangle = new OtherRectangle();

//what error do you think will populate here, and what's the difference between Rectangle and Other Rectangle?
//Console.WriteLine(oldRectangle.m_bottomRight._x.ToString(),rectangle.m_bottomRight._x.ToString());

//Console.WriteLine(
internal struct Point
{
    public Int32 _x, _y;

    public Point(Int32 x, Int32 y)
    {
        _x=x;
        _y=y;
    }
}

internal sealed class Rectangle
{
    public Point m_topLeft, m_bottomRight;

    public Rectangle()
    {
        m_topLeft = new Point(1, 2);
        m_bottomRight = new Point(5, 6);
    }
}

internal struct OtherPoint
{
    public Int32 _x, _y;

    public OtherPoint()
    {
        _x = _y = 5;
    }
}

internal sealed class OtherRectangle
{
    public OtherPoint m_topLeft, m_bottomRight;

    public OtherRectangle()
    {

    }
}
// Fundamentally, structs can be instantiated without "new"
// Once we add new and call the constructor, it can go through the 'alt, non default path'

//can't do this, you are not allowed to have instance field initializers in structs --> due to parameterless contstructors

//internal struct someValType
//{
//    private int a = 2;

//}

