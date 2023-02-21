int dias,hr,min,sec;

Console.WriteLine("Inserte Horas a Convertir");
hr = int.Parse(Console.ReadLine());

Console.WriteLine();
dias = hr / 24;
hr = hr % 24;
min = hr * 60;
sec = min * 60;

Console.WriteLine("Dias: "+dias);
Console.WriteLine("Minutos: "+min);
Console.WriteLine("Segundos: "+sec);


