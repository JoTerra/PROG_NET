int num1,num2,num3;

Console.Clear();
Console.WriteLine("Introduzca numeros");
num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());
num3 = int.Parse(Console.ReadLine());

if(num1 + 1 == num2 && num2 + 1 == num3){
    Console.WriteLine("Los Numeros son consecutivos!");
}else{
    Console.WriteLine("Lo siento, los numeros no son consecutivos");
}
