double n1, n2;
char op;
Console.WriteLine("Efectua operaciones matématicas básicas con 2 números\n");
Console.Write("Dame N1: "); n1 = double.Parse(Console.ReadLine());
Console.Write("Dame N2: "); n2 = double.Parse(Console.ReadLine());
Console.Write("Operacion : + , -, * , / , ^ ?\n");
op = Console.ReadLine()[0];
    switch(op){
        case '+': Console.WriteLine($"N1 + N2 = {n1 + n2}"); break; 
        case '-': Console.WriteLine($"N1 - N2 = {n1 - n2}"); break; 
        case '*': Console.WriteLine($"N1 * N2 = {n1 * n2}"); break; 
        case '/': Console.WriteLine($"N1 / N2 = {n1 / n2}"); break;
        case '^': Console.WriteLine($"N1 ^ N2 = {Math.Pow(n1,n2)}"); break; 
        default : Console.WriteLine("Invalid Operation..."); break;
    }
    Console.WriteLine("\nProcess terminated");