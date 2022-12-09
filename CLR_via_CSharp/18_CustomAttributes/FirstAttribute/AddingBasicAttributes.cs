// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Piece piece = new Piece();
piece.Name();

//
[Serializable]
class Piece
{
    internal void Name()
    {
        Console.WriteLine("A Queen");
    }
}