int dia;

Console.Clear();
Console.WriteLine("Ingrese un numero (1-10) para convertirlo a romano");
Console.Write("Ingrese el numero: "); dia = int.Parse(Console.ReadLine());
switch(dia){
    case 1 : Console.WriteLine("I\n"); break;
    case 2 : Console.WriteLine("II\n"); break;
    case 3 : Console.WriteLine("III\n"); break;
    case 4 : Console.WriteLine("IV\n"); break;
    case 5 : Console.WriteLine("V\n"); break;
    case 6 : Console.WriteLine("VI\n"); break;
    case 7 : Console.WriteLine("VII\n"); break;
    case 8 : Console.WriteLine("VIII\n"); break;
    case 9 : Console.WriteLine("IX\n"); break;
    case 10 : Console.WriteLine("X\n"); break;
    default : Console.WriteLine("Todavia no se inventan..."); break;
}
Console.WriteLine("\nProcess Terminated");