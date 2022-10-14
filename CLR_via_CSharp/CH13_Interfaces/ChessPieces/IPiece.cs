namespace ChessPieces;

public interface IPiece
{
    //properties --> good to know
    // can add indexers, events etc.
    Color Color { get; set; }
    Type Type { get; set; }
    void Move();
}