float Farenheit(float t) {
    return (t*9/5)+32;
}
float Celcius(float t) {
    return (t-32)*5/9;
}
int op;
float temp, res;
Console.Clear();
Console.Write("[1]Fahrenheit\n[2]Celsius\nElige ? ");
op = int.Parse(Console.ReadLine());
Console.Write("Dame la temperatura ? ");
temp = float.Parse(Console.ReadLine());
if(op==1) {
        res = Farenheit(temp);
        Console.WriteLine($"\n{temp} grados Celsius equivale a {res} grandos Fahrenheit.");
    }
    else if(op==2) {
        res = Celcius(temp);
        Console.WriteLine($"\n{temp} grados Fahrenheitequivale a {res} grandos Celsius.");
    }
else Console.WriteLine("Opción inválida");