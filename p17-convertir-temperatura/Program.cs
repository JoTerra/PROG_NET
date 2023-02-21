double temp1, temp2;
Console.WriteLine("Ingrese la temperatura(°F) a convertir");
temp1 = double.Parse(Console.ReadLine());

temp2 = (temp1 - 32) * (5/9);
Console.WriteLine("La Temperatura es: "+temp2);
