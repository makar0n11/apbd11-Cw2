using System;

Console.WriteLine("commit 1");
Console.WriteLine("commit 2");
Console.WriteLine("commit 3");

static double Avg(int[] tab)
{
    int sum = 0;
    foreach (int number in tab)
    {
        sum += number;
    }

    double avg = (double) sum / tab.Length;
    return avg;
} 

Console.WriteLine(Avg(new []{1,2,3,4}));

static int MaxValue(int[] tab)
{
    int max = tab[0];
    for (int i = 1; i < tab.Length ; i++ )
    {
        if (tab[i] > max)
        {
            max = tab[i];
        }
    }
    return max;
}

Console.WriteLine(MaxValue(new []{1,4,3,2}));
