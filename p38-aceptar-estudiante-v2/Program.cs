string stname;
char sex;
int age;
double tgrade = 0, grades = 0, ggrade = 0;

Console.WriteLine("Bienvenido al sistema de registro de la universidad Kitty Kat\nIntroduzca sus datos");
Console.WriteLine("Nombre: ");
stname = Console.ReadLine();
Console.WriteLine("Sexo (M, F) : ");
sex = Console.ReadLine()[0];
Console. WriteLine("Edad: ");
age = int.Parse(Console.ReadLine());
Console.WriteLine("Introduzca Calificaciones");
grades = double.Parse(Console.ReadLine());
tgrade = tgrade + grades;
grades = double.Parse(Console.ReadLine());
tgrade = tgrade + grades;
grades = double.Parse(Console.ReadLine());
tgrade = tgrade + grades;
ggrade = tgrade / 3;
    switch(sex){
        case 'F':
            if(ggrade >= 8 && ggrade <= 9.5 && age >= 21){
                Console.WriteLine($"Bienvenida a Kitty Kat SA, {stname}");
            }else{
                Console.WriteLine($"Lo sentimos, {stname}, no tienes el promedio suficiente, o no cuentas con la edad necesaria");
            }
            break;
        case 'M':
            Console.WriteLine($"Lo sentimos, {stname}, en este momento solo aceptamos estudiantes de sexo Femenino");
            break;
        default:
            Console.WriteLine("Lo sentimos, no cumples los requisitos para ingresar");
            break;
    }