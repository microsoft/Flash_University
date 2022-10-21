using System.Globalization;

var output = string.Empty;
string[] symbol = { "<", "=", ">" };
int x;
CultureInfo ci;

// The code below demonstrates how strings compare 
// differently for different cultures.
var s1 = "coté";
var s2 = "côte";

// Sorting strings for French in France.
ci = new CultureInfo("fr-FR");
x = Math.Sign(ci.CompareInfo.Compare(s1, s2));
output += string.Format("{0} Compare: {1} {3} {2}",
    ci.Name, s1, s2, symbol[x + 1]);
output += Environment.NewLine;

// Sorting strings for Japanese in Japan.
ci = new CultureInfo("ja-JP");
x = Math.Sign(ci.CompareInfo.Compare(s1, s2));
output += string.Format("{0} Compare: {1} {3} {2}",
    ci.Name, s1, s2, symbol[x + 1]);
output += Environment.NewLine;

// Sorting strings for the thread's culture
ci = Thread.CurrentThread.CurrentCulture;
x = Math.Sign(ci.CompareInfo.Compare(s1, s2));
output += string.Format("{0} Compare: {1} {3} {2}",
    ci.Name, s1, s2, symbol[x + 1]);
output += Environment.NewLine + Environment.NewLine;

// The code below demonstrates how to use CompareInfo.Compare's
// advanced options with 2 Japanese strings. One string represents
// the word "shinkansen" (the name for the Japanese high-speed 
// train) in hiragana (one subtype of Japanese writing), and the 
// other represents the same word in katakana (another subtype of 
// Japanese writing).
s1 = "しんかんせん"; // ("\u3057\u3093\u304B\u3093\u305b\u3093")
s2 = "シンカンセン"; // ("\u30b7\u30f3\u30ab\u30f3\u30bb\u30f3")

// Here is the result of a default comparison
ci = new CultureInfo("ja-JP");
x = Math.Sign(string.Compare(s1, s2, true, ci));
output += string.Format("Simple {0} Compare: {1} {3} {2}",
    ci.Name, s1, s2, symbol[x + 1]);
output += Environment.NewLine;

// Here is the result of a comparison that ignores 
// kana type (a type of Japanese writing)
var compareInfo = CompareInfo.GetCompareInfo("ja-JP");
x = Math.Sign(compareInfo.Compare(s1, s2, CompareOptions.IgnoreKanaType));
output += string.Format("Advanced {0} Compare: {1} {3} {2}",
    ci.Name, s1, s2, symbol[x + 1]);

Console.WriteLine(output);