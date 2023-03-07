int usert, packt, amount;
double subt, disc, tdisct;

void Menu(){
    Console.WriteLine("Introduzca el tipo de usuario");
    usert = int.Parse(Console.ReadLine());
    Console.WriteLine("Introduzca el tipo de paquete");
    packt = int.Parse(Console.ReadLine());
    Console.WriteLine("Introduzca la cantidad que desea adquirir");
    amount = int.Parse(Console.ReadLine());
}

if (args.Length < 3){
        Menu();
        return 1;
    }else{
        usert = int.Parse(args[0]);
        Run(usert);
        return 1;
    }

void Run(int usert){
packt = int.Parse(args[1]);
amount = int.Parse(args[2]);
switch(usert){
    case 1:
        disc = 0.20f;
        if(packt == 1){
            subt = amount * 700;
        }else if(packt == 2){
            subt = amount * 900;
        }else{
            subt = amount * 1000;
        }
        tdisct = subt - (subt * disc);
        Console.WriteLine($"Pedido: {amount} / Tipo de Usuario: {usert} / Tipo de Paquete: {packt}");
        Console.WriteLine($"Precio Normal: {subt} / Precio con Descuento: {tdisct}");
        break;
    case 2: 
        disc = 0.10f;
        if(packt == 1){
            subt = amount * 800;
        }else if(packt == 2){
            subt = amount * 1000;
        }else{
            subt = amount * 1100;
        }
        tdisct = subt - (subt * disc);
        Console.WriteLine($"Pedido: {amount} / Tipo de Usuario: {usert} / Tipo de Paquete: {packt}");
        Console.WriteLine($"Precio Normal: {subt} / Precio con Descuento: {tdisct}");
        break;
    case 3:
        disc = 0.05f;
        if(packt == 1){
            subt = amount * 1100;
        }else if(packt == 2){
            subt = amount * 1300;
        }else{
            subt = amount * 1400;
        }
        tdisct = subt - (subt * disc);
        Console.WriteLine($"Pedido: {amount} / Tipo de Usuario: {usert} / Tipo de Paquete: {packt}");
        Console.WriteLine($"Precio Normal: {subt} / Precio con Descuento: {tdisct}");
        break;
    default:
        break;
    }
}