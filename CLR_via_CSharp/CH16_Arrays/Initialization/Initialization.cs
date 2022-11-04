// Look at IL for this

var initial = new string[2];
initial[0] = "one";
initial[1] = "two";

string[] names = { "one", "two" };
// {} is called the array initializer, can be arbitrarily complex

//this is abusing the implict typing to get C# to assume that simliar is going to be of type String[]. this is called the 'implicit typed array'
var similiar = new[] { "one", "two" };



// var guess1 = new[] { "one", "two",null };
// var guess2 = new[] { null, "two", "three" };
// var guess3 = new[] { "one", "two", 3 };


// Note the lack of a 'new'
string[] valueOrReference = { "one", "two" };