var queen = new Queen();
var king = new King();
var citizen = new Citizen();
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

if (citizen.GetType().IsDefined(typeof(PieceAttribute), false))
{
    Console.WriteLine("A citizen is a piece");
}

if (citizen.GetType().IsDefined(typeof(PieceAttribute), true))
{
    Console.WriteLine("A citizen is a piece");
}

[PieceAttribute]
public class Queen : IPiece
{
}

[Piece]
public class King : IPiece
{
}

public class Citizen : King
{

}

[General]
internal interface IPiece
{
}

[AttributeUsage(AttributeTargets.All)]
public class PieceAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.All)]
public class GeneralAttribute : Attribute
{
}