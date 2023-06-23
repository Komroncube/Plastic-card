// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

Uzcard uzcard = new(12343563446, "Kamoliddin", 1000000);
uzcard.AddWithBonus(2000);
Console.WriteLine(uzcard.Money);

Humo humo = new(12343563446, "Kamoliddin", 1000000);
humo.AddWithBonus(2000);
Console.WriteLine(humo.Money);