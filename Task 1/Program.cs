using System;

Console.Write("Enter number of small rooms: ");
int small = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number of large rooms: ");
int large = Convert.ToInt32(Console.ReadLine());

int cost = (small * 250) + (large * 350);
double tax = cost * 0.14;
int total = cost + (int)tax;

Console.WriteLine("Estimate for carpet cleaning service");
Console.WriteLine("Number of small carpets: " + small);
Console.WriteLine("Number of large carpets: " + large);
Console.WriteLine("Price per small room: $250");
Console.WriteLine("Price per large room: $350");
Console.WriteLine("Cost: $" + cost);
Console.WriteLine("Tax: $" + (int)tax);
Console.WriteLine("Total estimate: $" + total);
Console.WriteLine("This estimate is valid for 30 days");