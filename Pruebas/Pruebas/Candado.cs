using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Pruebas
{
    internal class Candado //Cada candado tendrá una forma específica
    {
        private bool cerrado;
        private int cerradura;


        public Candado(int c) 
        {
            cerradura = c;
        }

        public void abrir(Llave l, Candado c)
        {
            if (l.getforma() == c.cerradura && c.cerrado==true)
            {
                c.cerrado=false;
                Console.WriteLine("El candado ha sido abierto");
            }
            else {
                if (c.cerrado==false)
                {
                    Console.WriteLine("El candado ya está abierto");
                }else Console.WriteLine("La llave no es la correcta");
            }
        } 
    }
}
