using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    public class Txt
    {
        public static void instrucciones()
        {
            Console.WriteLine("*Esto es un juego de abrir cofres.");
            Thread.Sleep(2200);
            Console.WriteLine("*Se elige la cantidad y se adivina que llave pertenece a cual cofre");
            Thread.Sleep(3000);
            Console.WriteLine("*Si adivinás, puedes pasar al siguiente nivel.");
            Thread.Sleep(2700);
            Console.WriteLine("*Hay una o más chances para romper los cofres dependiendo de la cantidad que se elijan...");
            Console.ReadLine();
        }

        public static void salir()
        {
            Console.Clear();
            Thread.Sleep(800);
            Console.Write("B");
            Thread.Sleep(100);
            Console.Write("a");
            Thread.Sleep(100);
            Console.Write("i");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(2000);

        }
    }
}
