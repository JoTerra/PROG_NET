int op;
Console.WriteLine("Bienvenido, Si quieres conocer los continentes, escribe un numero (1-6)!");
op = int.Parse(Console.ReadLine());
    switch(op){
        case 1: Console.WriteLine("Asia"); break;
        case 2: Console.WriteLine("África"); break;
        case 3: Console.WriteLine("América del Norte"); break;
        case 4: Console.WriteLine("América del Sur"); break;
        case 5: Console.WriteLine("Antártida"); break;
        case 6: Console.WriteLine("Europa"); break;
        default: Console.WriteLine("Ooops... Numero Invalido!"); break;
    }