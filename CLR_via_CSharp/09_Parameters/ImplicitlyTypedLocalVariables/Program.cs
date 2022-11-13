//combining msdn example w/ jeffrey

// i is compiled as an int
var i = 5;
ShowVariableType(i);

//var ok = null;
// s is compiled as a string
var s = "Hello";

ShowVariableType(s);
// a is compiled as int[]
var a = new[] { 0, 1, 2 };
ShowVariableType(a);

foreach (var val in a)
{
    ShowVariableType(val);
}


// anon is compiled as an anonymous type
var anon = new { Name = "Terry", Age = 34 };

ShowVariableType(anon);

// list is compiled as List<int>
var list = new List<int>();
ShowVariableType(list);
var x = (String)null;
ShowVariableType(x);

static void ShowVariableType<T>(T t)
{
    Console.WriteLine(typeof(T));
}