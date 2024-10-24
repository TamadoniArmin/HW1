
using System;
string number,firstname,lastname, Nationalcode,year,month, dateofmonth,email;
int counter = 0;
Console.WriteLine("please enter your infomation blow:");
Console.Write("Please enter you first name: ");
firstname = Console.ReadLine();
Console.Write("Please enter your lastname: ");
lastname = Console.ReadLine();
Console.Write("Please enter your phone numer (09...): ");
number = Console.ReadLine();
if ((number.Length!=11) || (number.Substring(0,2)!="09"))
{
    do
    {
        Console.WriteLine("the number that you have entered is incorrect! Please enter it correctly");
        Console.Write("Please enter your phone number (09...): ");
        number = Console.ReadLine();
    }
    while ((number.Length != 11) || (number.Substring(0, 2) != "09"));
}
counter++;
Console.Write("Please enter your national code: ");
Nationalcode = Console.ReadLine();
if (Nationalcode.Length != 10)
{
    do
    {
        Console.WriteLine("Your code is not correct! please enter it correctly");
        Console.Write("Please enter your national code: ");
        Nationalcode = Console.ReadLine();
    }
    while (Nationalcode.Length != 10);
}
counter++;
Console.WriteLine("Please enter your birth date: ");
Console.Write("year: ");
year = Console.ReadLine();
Console.Write("month: ");
month = Console.ReadLine();
Console.Write("date of month: ");
dateofmonth = Console.ReadLine();
if ((year.Length != 4) || (month.Length != 2) || (dateofmonth.Length != 2))
{
    do
    {
        Console.WriteLine("Date that you have entered is not correct! Please enter it correctly");
        Console.WriteLine("Please enter your birth date: ");
        Console.Write("year: ");
        year = Console.ReadLine();
        Console.Write("month: ");
        month = Console.ReadLine();
        Console.Write("date of month: ");
        dateofmonth = Console.ReadLine();
    }
    while ((year.Length != 4) || (month.Length != 2) || (dateofmonth.Length != 2));
}
counter++;
Console.Write("Please enter your email address: ");
email = Console.ReadLine();
if ((email.IndexOf('@') != email.LastIndexOf('@')) || (email.IndexOf('.') != email.LastIndexOf('.')))
{
    do
    {
        Console.WriteLine("email that you have entered is not correct! Please enter it correctly");
        Console.Write("Please enter your email address: ");
        email = Console.ReadLine();
    }
    while ((email.IndexOf('@') != email.LastIndexOf('@')) || (email.IndexOf('.') != email.LastIndexOf('.')));
}
counter++;
if(counter==4)
{ 
    Console.WriteLine("Your have entered all of your information correctly.");
    Console.WriteLine($"Your full name is: {firstname} {lastname}");
    Console.WriteLine($"Your phone number is: {number}");
    Console.WriteLine($"Your national code is: {Nationalcode}");
    Console.WriteLine($"Your date of birth is: {year}/{month}/{dateofmonth}");
    Console.WriteLine($"Your email address is: {email}");
}