using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Mecanicas
    {
        //MENU====================================================================================================
        public static int menúSelección(int valorMinimo, int valorMaximo, String menu)
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
                    if (valorMinimo-1 >= x || x >= valorMaximo+1)
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

        //JUEGO====================================================================================================

        //Creamos la lista de los cofres y llaves con sus "codigos" de forma aleatoria:
        public static void setElementos(List<Cofre> cofres, List<Llave> llaves, int n)
        {
            Random random = new Random();
            HashSet<int> num= new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int x;
                do
                {
                    x = random.Next(0, n);

                } while (num.Contains(x));

                
                cofres.Add(new Cofre(x));
            }

            num.Clear();

            for (int i = 0; i < n; i++)
            {
                int x;
                do
                {
                    x = random.Next(0, n);

                } while (num.Contains(x));


                llaves.Add(new Llave(x));
            }

        }

}
}
