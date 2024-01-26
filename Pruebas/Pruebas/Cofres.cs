using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Cofre
    {
        private int candado;
        private bool cerrado;

        private String contenido;
        private bool dureza; //Con esto sabremos si se puede romper el cofre
        public Cofre(String _contenido, bool _dureza,int candado) {
            contenido = _contenido;
            dureza = _dureza;
        }



        public void abrir(Llave l)
        {
            if (l.getforma() == candado && cerrado==true)
            {
                cerrado=false;
                Console.WriteLine("El candado ha sido abierto");
            }
            else {
                if (cerrado==false)
                {
                    Console.WriteLine("El candado ya está abierto");
                }else Console.WriteLine("La llave no es la correcta");
            }
        }
    }
}
