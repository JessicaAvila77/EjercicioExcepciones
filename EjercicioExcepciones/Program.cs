using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExcepciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Opcion;

            //Instanciando clase
            Operaciones operaciones = new Operaciones();

            do
            {
                Opcion = Menu();

                switch (Opcion)
                {
                    case 1:

                        try
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese el primer numero");
                            operaciones.N1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo numero");
                            operaciones.N2 = Convert.ToInt32(Console.ReadLine());

                            if (operaciones.N2 != 0)
                            {
                                Console.WriteLine("");
                                operaciones.Imprimir();

                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("El segundo numero no puede ser un 0 por la división");
                            }

                        }
                        catch (Exception error)
                        {
                            Console.WriteLine(error.Message);
                        }
                        finally
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Gracias por usar este programa");
                        }

                        break;

                    case 2:
                        
                        Console.WriteLine("Finalizando...");

                        break;  

                    default:
                        Console.WriteLine("Ingrese una opcion valida");

                    break;

                }

            } while (Opcion != 2);

        }

        public static int Menu()
        {
            int Opcion=0;

            Console.WriteLine("");
            Console.WriteLine("========================MENU====================:");
            Console.WriteLine("1. Realizar las operaciones basicas matematicas");
            Console.WriteLine("2. Salir");
            Console.Write("Ingrese una opcion:");
            Opcion = Convert.ToInt32(Console.ReadLine());
            return Opcion;

        }
    }
}
