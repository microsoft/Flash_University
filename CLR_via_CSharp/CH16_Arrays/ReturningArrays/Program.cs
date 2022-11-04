var output = LikelyValues(0);
for (int i = 0; i < output.Length; i++)
{
    Console.WriteLine(i);
}



var zeroArray = LikelyValues(2);
for (int i = 0; i < zeroArray.Length; i++)
{
    Console.WriteLine(i);
}

//var nullOutput = LikelyValues(1);
//for (int i = 0; i < nullOutput.Length; i++)
//{
//    Console.WriteLine(i);
//}



int[] LikelyValues(int input)
{
    if (input==0)
    {
        return new int[] { 1, 2 };
    }
    else if(input ==1)
    {
        return null;
    }
    else
    {
        return new int[0];
    }
}

