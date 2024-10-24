using System;
Console.WriteLine("Please enter your three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] a = new int[3];
for (int i =0;i<=2;i++)
{
    a[i] = number % 10;
    number = number / 10;
}
if (a[0] +a[2] == a[1])
{
    Console.WriteLine("true");
}
else
    Console.WriteLine("false");