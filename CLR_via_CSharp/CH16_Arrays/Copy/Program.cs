// This is a version of something I've run into

// Fundamentally, we have a data set with 'bad' data. We have a data set of integers that we need to calculate who lifted the best. 

// All lifters are in the same weight class

// THe weights are always integers

var totals = new int[] { 100, 95, 99 };

var totalsAsDoubles = new double[3];

Array.Copy(totals, totalsAsDoubles, totals.Length);

double sinclair = 1.5345234523453425;

foreach (var total in totals)
{
    Console.WriteLine(total*sinclair);
}

foreach (var total in totalsAsDoubles)
{
    Console.WriteLine(total * sinclair);
}

