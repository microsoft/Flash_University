namespace ChessPieces;

public interface IPiece
{
    Color Color { get; set; }
    Type Type { get; set; }
    void Move();
}