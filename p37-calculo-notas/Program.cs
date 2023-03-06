double fgrade = 0;
double grade, cont = 0;
Console.WriteLine("Introduzca Calificaciones");
grade = double.Parse(Console.ReadLine());
cont = cont + grade;
grade = double.Parse(Console.ReadLine());
cont = cont + grade;
grade = double.Parse(Console.ReadLine());
cont = cont + grade;
grade = double.Parse(Console.ReadLine());
cont = cont + grade;
grade = double.Parse(Console.ReadLine());
cont = cont + grade;
fgrade = cont / 5;
Console. WriteLine($"Tu calificación final: {fgrade}");
    switch(fgrade){
        case  > 0 and <= 6:
            Console.WriteLine("Quedas Reprobado");
            break;
        case > 6 and <= 7:
            Console.WriteLine("De Panzazo!");
            break;
        case  > 7 and <= 8:
            Console.WriteLine("Muy bien, puedes mejorar");
            break;
        case > 8 and <= 9:
            Console.WriteLine("Excelente, sigue así!");
            break;
        case  > 9 and <= 10:
            Console.WriteLine("Perfecto, tu esfuerzo valió la pena");
            break;
        default:
            break;

    }
