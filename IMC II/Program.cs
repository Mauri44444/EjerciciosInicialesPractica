using System.Reflection.PortableExecutable;

namespace IMC_II;

class Program
{
    // Metodo para calcular el IMC
    static double CalcularIMC(double peso, double altura)
    {
        return peso / (altura * altura);
    }

    static void Main()
    {
        try
        {
            Console.Clear();
            Console.Write("Ingrese su peso en kilogramos: ");  // Solicitar al usuario que ingrese su peso y altura
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Ingrese su altura en metros: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Clear(); //Todos los console clear son por estetica

            double imc = CalcularIMC(peso, altura);  // Declaracion de la variable imc utilizando el metodo que hicimos anteriormente
           
            Console.WriteLine($"Su IMC es: {imc:F2}"); // Mostrar el resultado

            Console.WriteLine("Presione cualquier tecla para salir");
            
            Console.ReadKey();
            Console.Clear();
        }
        catch (FormatException)
        {
            Console.WriteLine("Por favor, ingrese valores numéricos válidos para el peso y la altura."); // Usamos un TryCatch para asegurarnos de que el usuario no utilice letras
        }
    }
}
