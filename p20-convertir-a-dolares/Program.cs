double mxn, dlr;
double cot = 18.3970;

Console.WriteLine("Ingrese cantidad (MXN) a convertir");
mxn = double.Parse(Console.ReadLine());

dlr = mxn * cot;
Console.WriteLine("Dolares: "+dlr);