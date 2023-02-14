// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string amigo = "Juan";
string hermano = "Pablo";

Console.WriteLine(amigo);
amigo = "Miguel";
Console.WriteLine(amigo);
Console.WriteLine($"Hola {amigo} bienvenido a C#");
Console.WriteLine($"\nMi amigo es {amigo}, mi hermano es {hermano}\n");
Console.WriteLine("Nombres con mayusculas");
Console.WriteLine($"{amigo.ToUpper()} {hermano.ToUpper()}");