Console.WriteLine((int)ScoobyCrew.Fred);

Console.WriteLine((ScoobyCrew)4);

//look at ildasm and understand the values there --> see hexadecimal as well

internal enum ScoobyCrew
{
    Velma,
    Fred,
    Scooby,
    Shaggy,
    Daphne
}