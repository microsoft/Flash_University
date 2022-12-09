using Microsoft.VisualBasic;

string s1 = null;
string s2 = null;
string s3 = "s3";
string s4 = null;
var output = s1 ?? s2 ?? s3 ?? fetchString();

int? i1 = null;
int? i2 = null;

int? o2 = i1 ?? i2;

//Console.WriteLine(output);
Console.WriteLine(o2);


static string fetchString()
{
    Console.WriteLine("Definitely not a log");
    return "";
}