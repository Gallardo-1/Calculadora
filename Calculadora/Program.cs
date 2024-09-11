using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Title = "Calculadora ";
            string op;

            do
            {
                Console.Clear();
                Console.WriteLine("------------------------------");
                Console.WriteLine("Calculadora ");
                Console.WriteLine("Opciones del menu");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1) Sumar. ");
                Console.WriteLine("2) Restar.");
                Console.WriteLine("3) Multiplicar.");
                Console.WriteLine("4) Dividir. ");
                Console.WriteLine("5) Salir.");
                

                op = Console.ReadLine();
                switch (op)
                {
                    case "1":
                        Sumar();
                        break;

                    case "2":
                        Restar();
                        break;

                    case "3":
                        Multiplicar();
                        break;
                        
                    case "4":
                        Dividir();
                        break;

                    case "5":
                        Console.WriteLine("Buen viaje!");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida intente de nuevo...");
                        break;
                }
                Console.ReadKey();

            }
            while (op != "5");

        }

        static void Sumar()
        {

            decimal num1, num2, resultado;

            Console.WriteLine("Ingresa el primero numero");
            num1 = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("Ingresa el segundo numero");
            num2 = Convert.ToDecimal(Console.ReadLine());


            resultado = num1 + num2;

            Console.WriteLine("{0} + {1} = {2}", num1, num2, resultado);


        }

        static void Restar()
        {

            decimal num1, num2, resultado;

            Console.WriteLine("Ingresa el primero numero");
            num1 = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("Ingresa el segundo numero");
            num2 = Convert.ToDecimal(Console.ReadLine());


            resultado = num1 - num2;

            Console.WriteLine("{0} - {1} = {2}", num1, num2, resultado);


        }

        static void Multiplicar()
        {

            decimal num1, num2, resultado;

            Console.WriteLine("Ingresa el primero numero");
            num1 = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("Ingresa el segundo numero");
            num2 = Convert.ToDecimal(Console.ReadLine());


            resultado = num1 * num2;

            Console.WriteLine("{0} * {1} = {2}", num1, num2, resultado);


        }

        static void Dividir()
        {

            decimal num1, num2, resultado;

            Console.WriteLine("Ingresa el primero numero");
            num1 = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("Ingresa el segundo numero");
            num2 = Convert.ToDecimal(Console.ReadLine());


            resultado = num1 / num2;

            Console.WriteLine("{0} / {1} = {2}", num1, num2, resultado);


        }


    }
}
