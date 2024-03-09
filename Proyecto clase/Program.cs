//Funciones
static void Suma()
{
    int respuesta, val1, val2 = 0;
    Console.WriteLine("Ingrese valor 1: ");
    val1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese valor 2: ");
    val2 = Convert.ToInt32(Console.ReadLine());
    respuesta = val1 + val2;
    Console.WriteLine("Suma = " + respuesta);
    Console.ReadKey();
    Console.Clear();
}

static void Datos()
{
    //Ejercicio 2
    Console.WriteLine("Cual es su nombre: ");
    string nombre = Console.ReadLine();
    Console.WriteLine("Mucho gusto " + nombre);
    Console.ReadKey();
    Console.Clear();
}

static void CalculoEdad()
{
    //Ejercicio 3
    Console.WriteLine("Ingrese su año de nacimiento: ");
    int yearBorn = Convert.ToInt32(Console.ReadLine());
    int edad = yearBorn - 2024;
    Console.WriteLine("Su edad es= " + edad);
    Console.ReadKey();
    Console.Clear();
}

//Bloque de datos reutilizable
static int Suma1(int val1, int val2,int val3)
{
    return val1 + val2 + val3;
   
}
int promedio = Suma1(30, 20, 40)/3;
Console.WriteLine(promedio);
promedio = Suma1(50, 60, 40);

static string Datos1()
{
    string nombre = " ";
    Console.Write("Ingrese nombre: ");
    nombre = Console.ReadLine();
    return nombre;
  
}

/*
int opcion = 0;
do
{
    Console.WriteLine("1. Suma ");
    Console.WriteLine("2. Datos ");
    Console.WriteLine("3. Calculo Edad ");
    Console.WriteLine("4. Salir ");
    Console.Write("Opcion :");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Suma();
            break;
        case 2:
            Datos();
            break;
        case 3:
            CalculoEdad();
            break;
    }
} while (opcion != 4);
*/