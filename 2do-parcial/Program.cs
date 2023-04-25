const int MAX = 100;
double [] Nums = new double [MAX];
double suma = 0;
double promedio = 0;
int op;
int n = 0;
double nb, pos;

do{
 op = menu();
    switch (op)
    {
        case 1:
        System.Console.WriteLine("Cuantos elementos deseas?");
        n = int.Parse(Console.ReadLine());
        if (n > MAX)
        {
            System.Console.WriteLine("Te excediste");
        }else
        {
            for (int i = 0; i < n; i++)
            {
                System.Console.Write($"Elemento [{i+1}]");
                Nums[i] = double.Parse(Console.ReadLine());
                
            }
        }
        break;
        case 2: Mostrar(Nums, n);
            break;
        case 3:
            suma = Sumar(Nums, n);
            promedio = suma / Nums.Length;
            MostrarMayorPromedio(Nums, n, promedio);
            break;
        case 4: 
            MostrarComplemento(Nums, n);
            break;
        case 5:
        System.Console.WriteLine("\nQue elemento buscas?");
        nb = double.Parse(Console.ReadLine());
        pos = BuscarContar(Nums, nb, n);
        if (pos > 1){
            System.Console.WriteLine($"Encontrado elemento: {nb} un total de {pos} veces");
        }else{
            System.Console.WriteLine($"No se ha encontrado el elemento{nb}");
        }
        break;
        default:
            break;
    }
    
    System.Console.WriteLine("\nPresione cualquier tecla para continuar..");
    Console.ReadLine();
} while (op != 6);

int menu(){
    Console.Clear();
    System.Console.WriteLine("Leer Calificaciones                          [1]");
    System.Console.WriteLine("Mostrar Calificaciones                       [2]");
    System.Console.WriteLine("Calcular y mostrar mayores al promedio       [3]");
    System.Console.WriteLine("Mostrar Complemento a 100                    [4]");
    System.Console.WriteLine("Contar Calificaciones                        [5]");
    System.Console.WriteLine("Salir                                        [6]");
    System.Console.WriteLine("Elige una Opción");

    int op = int.Parse(Console.ReadLine());
    return op;
}

void Mostrar(double[] a, int n){
    for (int i = 0; i < n; i++)
    {
        System.Console.WriteLine($"{a[i]}");
    }
}

void MostrarMayorPromedio(double[] a, int n, double promedio){
    double suma = Sumar(a, n);
    double promFunct = suma / a.Length;
    for (int i = 0; i < n; i++)
    {
        if(a[i] > promFunct){
            System.Console.WriteLine($"{a[i]}");
        }else{

        }
    }
}

void MostrarComplemento(double[] a, int n){
    double value;
    for (int i = 0; i < n; i++)
    {
        value = 100 - a[i];
        System.Console.WriteLine($"{value}");
    }
}

double Sumar(double[] a, int n){
    double suma = 0;
    for (int i = 0; i < n; i++)
        suma = suma + a[i];
        return suma;

}

double BuscarContar(double[] a, double nb, int n){
    int pos = 1;
    int nt = 0;
    for (int i = 0; i < n; i++)
    if (a[i] == nb)
        ++nt;

    return nt;
    
}