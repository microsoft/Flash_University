var crew = (ScoobyCrew[])Enum.GetValues(typeof(ScoobyCrew));
foreach (var being in crew) Console.WriteLine(being);

var arr = ScoobyCrew.Velma.GetType().GetEnumValues();

foreach (var being in arr) Console.WriteLine(being);


var values = GetEnumValues<ScoobyCrew>();
foreach (var being in values) Console.WriteLine(being);


var output = Enum.Parse(typeof(ScoobyCrew), "Velma", true);
Console.WriteLine(output);

// Jeffrey's Method/finest moment, pg 365
static TEnum[] GetEnumValues<TEnum>() where TEnum : struct
{
    return (TEnum[])Enum.GetValues(typeof(TEnum));
}

internal enum ScoobyCrew
{
    Velma,
    Fred,
    Scooby,
    Shaggy,
    Daphne
}