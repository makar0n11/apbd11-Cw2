using System;

Console.WriteLine("commit 1");
Console.WriteLine("commit 2");
Console.WriteLine("commit 3");

static double Avg(int[] tab)
{
    int sum = 0;
    foreach (int num in tab)
    {
        sum += num;
    }

    double avg = (double) sum / tab.Length;
    return avg;
} 

Console.WriteLine(Avg(new []{1,2,3,4}));
