using System;

public class Program
{
    public static int ObtenerEntero(string mensaje)
    {
        int numero;
        while (true)
        {
            Console.Write(mensaje);
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                return numero;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            }
        }
    }

    public static double ObtenerDouble(string mensaje)
    {
        double numero;
        while (true)
        {
            Console.Write(mensaje);
            if (double.TryParse(Console.ReadLine(), out numero))
            {
                return numero;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número decimal.");
            }
        }
    }

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nBienvenidos a la calculadora de áreas, por favor elija el tipo de figura a la que le vamos a calcular el área:");
            Console.WriteLine("1. Cuadrado\n2. Rectángulo\n3. Triángulo\n4. Círculo\n5. Salir del programa\n");

            int eleccion = ObtenerEntero("Ingrese el número correspondiente a la figura: ");

            if (eleccion == 5)
            {
                break;
            }

            double parametro1 = ObtenerDouble("Ingrese el valor del primer parámetro: ");
            double parametro2 = ObtenerDouble("Ingrese el valor del segundo parámetro: ");

            FormaGeometrica figura = null;

            switch (eleccion)
            {
                case 1:
                    figura = new Cuadrado(parametro1, parametro2);
                    break;
                case 2:
                    figura = new Rectangulo(parametro1, parametro2);
                    break;
                case 3:
                    figura = new Triangulo(parametro1, parametro2);
                    break;
                case 4:
                    figura = new Circulo(parametro1, parametro2);
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elija una figura válida.");
                    continue;
            }

            string resultado = figura.CalcularArea();
            Console.WriteLine(resultado);
        }

        Console.WriteLine("Hasta pronto");
    }
}
