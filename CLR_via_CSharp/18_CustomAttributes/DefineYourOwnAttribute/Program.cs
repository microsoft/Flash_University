var queen = new Queen();
var king = new King();

//Detecting a king

if (king.GetType().IsDefined(typeof(GeneralAttribute), true))
{
    // Why does this not work?
    Console.WriteLine("A king is a general");
}

if (king.GetType().IsDefined(typeof(PieceAttribute), false))
{
    Console.WriteLine("A king is a piece");
}

[PieceAttribute]
public class Queen : IPiece
{
}

[Piece]
public class King : IPiece
{
}

[General]
internal interface IPiece
{
}

[AttributeUsage(AttributeTargets.All)]
public class PieceAttribute : Attribute
{
    public PieceAttribute()
    {
    }
}

[AttributeUsage(AttributeTargets.All)]
public class GeneralAttribute : Attribute
{
    public GeneralAttribute()
    {
    }
}