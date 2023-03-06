char pzt;
int amount, price, tbought;
double fprice, discount = 0;

Console.WriteLine("Introduce el tamaño de Pizza que deseas!");
Console.WriteLine("C - Chica $5, M - Mediana $10, G - Grande $20");
pzt = Console.ReadLine()[0];
Console.WriteLine("¿Cuantas unidades deseas?");
amount = int.Parse(Console.ReadLine());
    switch(pzt){
        case 'C': 
            tbought = amount * 5;
            if(tbought > 2000){
                discount = 0.15 * tbought;
                fprice = tbought - discount;
            } else {
                fprice = tbought;
            }
            Console.WriteLine($"Tamaño de la compra: {pzt}");
            Console.WriteLine($"Cantidad Adquirida: {amount}");
            Console.WriteLine($"Total de Compra: {tbought}");
            Console.WriteLine($"Descuento: {discount}");
            Console.WriteLine($"Total de Compra tras Descuento:{fprice}");
            break;
        case 'M': 
            tbought = amount * 10;
            if(tbought > 2000){
                discount = 0.15 * tbought;
                fprice = tbought - discount;
            } else {
                fprice = tbought;
            }
            Console.WriteLine($"Tamaño de la compra: {pzt}");
            Console.WriteLine($"Cantidad Adquirida: {amount}");
            Console.WriteLine($"Total de Compra: {tbought}");
            Console.WriteLine($"Descuento: {discount}");
            Console.WriteLine($"Total de Compra tras Descuento:{fprice}");
            break;
        case 'G': 
            tbought = amount * 20;
            if(tbought > 2000){
                discount = 0.15 * tbought;
                fprice = tbought - discount;
            } else {
                fprice = tbought;
            }
            Console.WriteLine($"Tamaño de la compra: {pzt}");
            Console.WriteLine($"Cantidad Adquirida: {amount}");
            Console.WriteLine($"Total de Compra: {tbought}");
            Console.WriteLine($"Descuento: {discount}");
            Console.WriteLine($"Total de Compra tras Descuento:{fprice}");
            break;
        default:
            Console.WriteLine("Lo siento, no tenemos este tamaño aún");
            break;
    }