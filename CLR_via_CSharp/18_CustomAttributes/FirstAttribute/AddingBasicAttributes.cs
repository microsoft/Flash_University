// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
var piece = new Piece();
piece.Name();

//
[Serializable]
internal class Piece
{
    internal void Name()
    {
        Console.WriteLine("A Queen");
    }
}