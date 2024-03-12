using System;

Console.WriteLine("Hello World");
Console.WriteLine("commit 2");
Console.WriteLine("commit 3");

static double Avg(int[] tab)
{
    int sum = 0;
    foreach (int num in tab)
    {
        sum += sum + num;
    }

    double avg = sum / tab.Length;
    return avg;
} 

Console.WriteLine(Avg(new []{1,2,3,4}));