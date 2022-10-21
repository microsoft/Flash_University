
using System.Globalization;

String s1 = "Strasse";
String s2 = "Straße";
Boolean eq;

// CompareOrdinal returns nonzero.
eq = String.Compare(s1, s2, StringComparison.Ordinal) == 0;
Console.WriteLine("Ordinal  comparison: '{0}' {2} '{1}'", s1, s2,
    eq ? "==" : "!=");

// Compare Strings appropriately for people 
// who speak German (de) in Germany (DE)
CultureInfo ci = new CultureInfo("de-DE");

// Could not get this to work. Direct from book example...
eq = String.Compare(s1, s2, true, ci) == 0;
Console.WriteLine("Cultural comparison: '{0}' {2} '{1}'", s1, s2,
    eq ? "==" : "!=");                                      