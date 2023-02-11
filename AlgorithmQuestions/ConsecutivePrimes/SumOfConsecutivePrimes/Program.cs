List<int> primesList = new List<int>(){2};

int maxValue = 50;

int i = 2;


while (i < maxValue)
{
    bool isPrime = true;

    foreach (int prime in primesList)
    {
        if (i % prime == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        primesList.Append(i);
        Console.WriteLine(i);
    }
    i++;
}
// public static 
// for (int  =primesList.Count-1;)
// int left = 0;
// int right = 0;
// int sum = 0;
