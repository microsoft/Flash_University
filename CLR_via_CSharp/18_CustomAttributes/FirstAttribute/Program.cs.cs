var piece = new Piece();
piece.Name();

[Serializable]
internal class Piece
{
    internal void Name()
    {
        Console.WriteLine("A Queen");
    }
}