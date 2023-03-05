int dia;

Console.Clear();
Console.WriteLine("Dadp un numero entre 1 y 7 imprima el dia de la semana");
Console.Write("Dame el dia con numero: "); dia = int.Parse(Console.ReadLine());
switch(dia){
    case 1 : Console.WriteLine("Lunes\n"); break;
    case 2 : Console.WriteLine("Martes\n"); break;
    case 3 : Console.WriteLine("Miercoles\n"); break;
    case 4 : Console.WriteLine("Jueves\n"); break;
    case 5 : Console.WriteLine("Viernes\n"); break;
    case 6 : Console.WriteLine("Sabado\n"); break;
    case 7 : Console.WriteLine("Domingo\n"); break;
    default : Console.WriteLine("Ah caray, en que dia vives?"); break;
}
Console.WriteLine("\nProcess Terminated");