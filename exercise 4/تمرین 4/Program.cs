using System;
int[] a = new int[5];
double sum = 0,avg;
for (int i = 0 ; i <= 4 ;i++)
{
    Console.Write($"Please enter {i + 1} number: ");
    a[i] = Convert.ToInt32(Console.ReadLine());
    sum = sum + a[i];
}
avg = sum / 5;
avg = Math.Floor(avg);
Console.WriteLine(avg);
if (avg % 2 == 0)
{
    Console.WriteLine("true");
}
else
    Console.WriteLine("false");