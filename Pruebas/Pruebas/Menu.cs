using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Menu
    {
        public static int menuSeleccion(int valorMinimo, int valorMaximo, String menu)
        {
            String input;
            int x = 0;
            bool a = false;
            while (a == false)
            {

                Console.Clear();
                Console.WriteLine(menu);
                Console.WriteLine("\nIngrese una opción: \n");
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    // Asignando un valor predeterminado si la entrada está vacía
                    input = "Error";
                }

                if (int.TryParse(input, out int n))
                {
                    x = int.Parse(input);
                    if (valorMinimo - 1 >= x || x >= valorMaximo + 1)
                    {
                        Console.WriteLine("Ingrese una opción válida");
                        Thread.Sleep(1500);
                    }
                    else a = true;
                }
                else
                {
                    Console.WriteLine("\nEntrada no válida. Asegúrese de ingresar un número entero.");
                    Thread.Sleep(1500);
                }


            }
            return x;
        }

        public static int menuJuego(int n, int intentos, int rompe, int monedas)
        {
            int opcion = Menu.menuSeleccion(0, n, Texto.menu3);
            //He de continuar por aqui
            int mon=0;
            return mon;
        }

    }
}
