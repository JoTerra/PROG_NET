double l1,l2,hip;
Console.WriteLine("Ingrese el Lado 1");
l1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el Lado 2");
l2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la Hipotenusa");
hip = Math.Sqrt(Math.Pow(l1,2) + Math.Pow(l2,2));
Console.WriteLine("La hipotenusa resulta en : " +hip);