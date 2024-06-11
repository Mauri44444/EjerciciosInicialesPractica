namespace EJERCICIOS_PRACTICA_INICIALES;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su primer numero: ");
        
        double N1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese su segundo numero: ");

        double N2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese su tercer numero");

        double N3 = Convert.ToDouble(Console.ReadLine());

        double promedio = (N1 + N2 + N3) / 3;

        Console.WriteLine("El promedio de los 3 numeros es = " + promedio);
    }
}
