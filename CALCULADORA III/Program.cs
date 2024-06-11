namespace CALCULADORA_III;

class Program
{
    static void Main(string[] args)
    {
        while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Seleccione la operación a realizar:"); // Se le pide al usuario que seleccione una operacion
                    Console.WriteLine("1. Suma");
                    Console.WriteLine("2. Resta");
                    Console.WriteLine("3. Multiplicación");
                    Console.WriteLine("4. División");
                    Console.WriteLine();
                    
                    int operacion = Convert.ToInt32(Console.ReadLine()); // Se declaran las variables operacion y resultado

                    double resultado = 0;

                    Console.Clear();
                    Console.WriteLine("Ingrese el primer número:");     
                    double numero1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine();                                // Se le pide al usuario que ingrese 2 numeros

                    Console.WriteLine("Ingrese el segundo número:");
                    double numero2 = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();


                    
                    switch (operacion)                                  // Utilizamos un Switch para que dependiendo de cual operacion elija el usuario, se active un metodo distinto
                    {
                        case 1:
                            resultado = Sumar(numero1, numero2);
                            Console.WriteLine($"Resultado: {numero1} + {numero2} = {resultado}");
                            break;
                        case 2:
                            resultado = Restar(numero1, numero2);
                            Console.WriteLine($"Resultado: {numero1} - {numero2} = {resultado}");
                            break;
                        case 3:
                            resultado = Multiplicar(numero1, numero2);
                            Console.WriteLine($"Resultado: {numero1} * {numero2} = {resultado}");
                            break;
                        case 4:
                            resultado = Dividir(numero1, numero2);
                            Console.WriteLine($"Resultado: {numero1} / {numero2} = {resultado}");
                            break;
                        default:
                            Console.WriteLine("Operación no válida. Por favor, seleccione una operación entre 1 y 4."); // El default es para que el usuario no ponga otro numero que no sea del 1 al 4
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Error: Por favor, ingrese un número válido.");
                    Console.WriteLine();  // Aca se utilizan dos catch. Uno para que el usuario no ingrese letras y otro para que el usuario no divida entre 0
                }
                catch (DivideByZeroException)
                {
                    Console.Clear();
                    Console.WriteLine("Error: No se puede dividir por cero.");
                    Console.WriteLine(); 
                }

                Console.WriteLine(); 
                Console.WriteLine("¿Desea realizar otra operación? (s/n):"); // Se le pregunta al usuario si desea continuar
                Console.WriteLine();
                
                string continuar = Console.ReadLine();
                if (continuar.ToLower() != "s")
                {
                    break;           // En caso que diga que no, se cierra el programa
                }
            }
        }

        static double Sumar(double a, double b)                         
        {
            return a + b;
        }

        static double Restar(double a, double b)
        {
            return a - b;
        }

        static double Multiplicar(double a, double b)                       // Se utilizan 4 metodos que son los de suma, resta, multiplicacion y division
        {
            return a * b;
        }

        static double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();                         // En caso que el usuario divida un numero entre 0, le va a tirar un error 
            }
            return a / b;
        }
}
