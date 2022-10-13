using ChessPieces;
using Type = ChessPieces.Type;

var knight = new Knight();
knight.Color = Color.White;
knight.Type = Type.Knight;

//Is this the best way to do things? No. but this is a problem I had that angered me for a few weeks because I couldn't get my implementation of IPiece to look pretty