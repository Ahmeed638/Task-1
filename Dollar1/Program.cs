using System;
using System.Threading.Channels;


Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();
Console.WriteLine("count your small rooms: ");
int SmallRoom = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("count your big rooms");
int LargeRoom = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("This is an offer for 30 days");
Console.WriteLine("price for 1 small carpet is 250$");
Console.WriteLine("price for 1 big carpet is 350$");
Console.WriteLine("There is 14% added tax");

double Total = (SmallRoom * 250) + (LargeRoom * 350);
Console.WriteLine($"your in voive before taxes {Total}");
double total2 = Total + Total*.14;
Console.WriteLine($"Your total invoice after taxes {total2}");




