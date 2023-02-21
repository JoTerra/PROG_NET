double vol, rad, alt;
const double pi = 3.1415926;
Console.WriteLine("Escriba el radio deseado");
rad = double.Parse(Console.ReadLine());
Console.WriteLine("Escriba la altura deseada");
alt = double.Parse(Console.ReadLine());

vol = pi * Math.Pow(rad,2) * alt;
Console.WriteLine("El volumen de este cilindro es: "+ vol);