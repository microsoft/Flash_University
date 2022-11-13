//Directly from the book

//note the difference from the simple insantiator.

//how would we create a triple so x,y,z

using System.Drawing;

var doubles = new double[10, 20];

var triples = new double[10, 20, 30];


//what if we don't want to instantiate?
//double[,,] emptyTriples = new double[,,] { };


//Jagged Arrays

//this is a value type of Point
var polygons = new Point[3][];

polygons[0] = new Point[10];
polygons[1] = new Point[20];
polygons[2] = new Point[30];

//