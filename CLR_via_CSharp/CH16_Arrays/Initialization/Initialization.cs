// Look at IL for this

var initial = new string[2];
initial[0] = "one";
initial[1] = "two";

string[] names = { "one", "two" };
// {} is called the array initializer, can be arbitrarily complex

//this is abusing the implict typing to get C# to assume that simliar is going to be of type String[]
var similiar = new[] { "one", "two" };


//abusing your array power