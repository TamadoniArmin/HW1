using System;
Console.Write("Please enter your first number: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter your second number: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter your third number: ");
int C = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter your fourth number: ");
int D = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter your fifth number: ");
int E = Convert.ToInt32(Console.ReadLine());
int maxamoumt = A;
int minamount = A;
// this program will show you the maxamount.
if (B>maxamoumt)
{
    maxamoumt = B;
}
if (C>maxamoumt)
{
    maxamoumt = C;
}
if (D>maxamoumt)
{
    maxamoumt = D;
}
if (E>maxamoumt)
{
    maxamoumt = E;
}
// Now this program will show the minamount.
if (B<minamount)
{
    minamount = B;
}
if (C<minamount)
{
    minamount = C;
}
if (D<minamount)
{
    minamount = D;
}
if (E<minamount)
{
    minamount = E;
}
Console.WriteLine($"The maxamount is: {maxamoumt}  and the minamount is: {minamount}");