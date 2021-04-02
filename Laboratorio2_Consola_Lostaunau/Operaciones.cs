using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2_Consola_Lostaunau
{
    class Operaciones
    {
        static void Main(string[] args)
        {
            //Declarar variables
            double a, b, r;
            int opcion;

            Console.WriteLine("==========================================");
            Console.WriteLine("         Operaciones Aritmeticas          ");
            Console.WriteLine("==========================================");
            //solicitar valores por teclado

            Console.WriteLine("Escriba el valor de A: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el valor de B: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la opcion del 1 al 4: ");
            opcion = int.Parse(Console.ReadLine());

            //Realizando el calculo
            if (opcion > 0 && opcion <= 5)
            {
                switch (opcion)
                 {
                    case 1:
                        r = a + b;
                        Console.WriteLine("La suma es: " + r);
                        break;
                    case 2:
                        r = a - b;
                        Console.WriteLine("La resta es: " + r);
                        break;
                    case 3:
                        r = a * b;
                        Console.WriteLine("La multiplicacion es: " + r);
                        break;
                    case 4:
                        if (b > 0) 
                        {
                            r = a / b;
                            Console.WriteLine("La division es: " + r);
                        }
                        else
                        {
                            Console.WriteLine("El valor de b tiene que ser distinto a cero.");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opcion Invalida.");
            }
        }
    }
}
