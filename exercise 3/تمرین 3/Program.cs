using System;
using System.ComponentModel.Design;
int[] A = new int[3];
for (int i = 0;i<3;i++)
{
    Console.Write($"Please enter {i+1} number: ");
    A[i]=Convert.ToInt32(Console.ReadLine());
}
int first, second, third;
if (A[0] >= A[1] && A[0] >= A[2])
{
    first = A[0];
    if (A[1] >= A[2])
    {
        second = A[1];
        third = A[2];
    }
    else
    {
        second = A[2];
        third = A[1];
    }
}
else

    if (A[1] >= A[0] && A[1] >= A[2])
    {
        first = A[1];
        if (A[0] >= A[2])
        {
            second = A[0];
            third = A[2];
        }
        else
        {
            second = A[2];
            third = A[0];
        }
    }
else
{
    first = A[2];
    if (A[0] >= A[1])
    {
        second = A[0];
        third = A[1];
    }
    else
    {
        second = A[1];
        third = A[0];
    }

}
Console.WriteLine("the correct order of your number is: ");
Console.WriteLine(third);
Console.WriteLine(second);
Console.WriteLine(first);