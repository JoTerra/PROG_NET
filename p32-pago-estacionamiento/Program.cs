// Administra el pago por estacionamiento de acuerdo a la zona

int op;
float pago, tasa, impuesto, total;

Console.Clear();
Console.WriteLine("Administra el pago por estacionamiento de acuerdo a la Zona\n");
Console.WriteLine("1 - Estacionamiento Tacuba 3%");
Console.WriteLine("2 - Estacionamiento Portales 5%");
Console.WriteLine("3 - Estacionamiento Conquistadores 10%");
Console.WriteLine("4 - Estacionamiento Pajaros Cidos 15%");
Console.WriteLine("Elije Opcion: ");
op = int.Parse(Console.ReadLine());
Console.Write("Pago Efectuado: "); pago = float.Parse(Console.ReadLine());
tasa = 0.0f;
switch(op){
    case 1 : tasa = 0.03f; break;
    case 2 : tasa = 0.05f; break;
    case 3 : tasa = 0.10f; break;
    case 4 : tasa = 0.15f; break;
}

impuesto = pago * tasa;
total = pago + impuesto;
string salida = String.Format($"Elegiste el estacionamiento {op} \n" + 
        $"Su pago: ${pago} por el uso del estacionamiento\n" +
        $"El impuesto es de: ${impuesto:n2}\n" +
        $"Total = ${total:n2}");
Console.WriteLine(salida);