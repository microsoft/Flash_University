var primes = unoptimizedPrimeSieve(1000000);
Console.WriteLine(string.Join( ",", primes));

var reversedPrimes = new List<int>(primes).ToArray();


foreach (int i in reversedPrimes.Reverse())
{
    Console.WriteLine($"testing {i}");
    if (findConsecutivePrimeSums(primes, i))
    {
        Console.WriteLine($"Solution is {i}");
        break;
    }
}
static List<int> unoptimizedPrimeSieve(int maxValue)
{
    List<int> primesList = new List<int>() { 2 };
    int i = 3;
    while (i <= maxValue)
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
            primesList.Add(i);
        }
        i = i+2;
    }
    return primesList;
}

static bool findConsecutivePrimeSums(List<int> orderedPrimes, int targetValue)
{
    int left= 0, right= 2, sum = orderedPrimes[0] + orderedPrimes[1];
    while (sum != targetValue && right < orderedPrimes.Count && left < right && right-left>1)
    {
        if (sum < targetValue)
        {
            sum += orderedPrimes[right];
            right++;
        }
        else
        {
            sum -= orderedPrimes[left];
            left++;
        }
    }

    if (sum == targetValue)
    {
        return true;
    }
    return false;
}







