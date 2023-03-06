int num1,num2,num3;

Console.Clear();
Console.WriteLine("Introduzca numeros");
num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());
num3 = int.Parse(Console.ReadLine());

if(num1 > num2 && num1 > num3){
    Console.WriteLine($"El numero 1: {num1} - es el mayor!");
}else if(num2 > num1 && num2 > num3){
    Console.WriteLine($"El numero 2: {num2} - es el mayor!");
}else{
    Console.WriteLine($"El numero 3: {num3} - es el mayor!");
}
