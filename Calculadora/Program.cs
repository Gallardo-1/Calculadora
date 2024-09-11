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
                        
                        break;

                    case "2":
                        
                        break;

                    case "3":
                        
                        break;

                    case "4":
                        
                        break;

                    case "5":
                        Console.WriteLine("Buen viaje!- GT17016-HENRY GALLARDO");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida intente de nuevo...");
                        break;
                }
                Console.ReadKey();

            }
            while (op != "5");

        }
    }
}
