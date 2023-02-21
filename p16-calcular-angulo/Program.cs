double ang1, ang2, ang3;
Console.WriteLine("Inserte Angulo 1");
ang1 = double.Parse(Console.ReadLine());
Console.WriteLine("Inserte Angulo 2");
ang2 = double.Parse(Console.ReadLine());
ang3 = 180 - (ang1 + ang2);
Console.WriteLine("El Resultado(Angulo 3) es: " + ang3);