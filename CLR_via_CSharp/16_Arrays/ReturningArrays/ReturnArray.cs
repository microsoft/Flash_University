var output = LikelyValues(0);
for (var i = 0; i < output.Length; i++) Console.WriteLine(i);


var zeroArray = LikelyValues(2);
for (var i = 0; i < zeroArray.Length; i++) Console.WriteLine(i);

//var nullOutput = LikelyValues(1);
//for (int i = 0; i < nullOutput.Length; i++)
//{
//    Console.WriteLine(i);
//}


int[] LikelyValues(int input)
{
    if (input == 0)
        return new[] { 1, 2 };
    if (input == 1)
        return null;
    return new int[0];
}