using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Cofre
    {
        Random random= new Random();
        private int candado;
        private bool cerrado;
        private String[] basura= {"Taza rota","Pan con Hongos","Carton Mojado"};
        private String contenido; 

        private bool dureza; //Con esto sabremos si se puede romper el cofre
        public Cofre(int _candado) {
            
            this.contenido= basura[random.Next(basura.Length)];
            this.candado= _candado;
            this.cerrado=true;
            
        }

        public String getContenido()
        {
            return contenido;
        }

        public void setCandado(int c)
        {
            this.candado= c;
        }

        public void setDureza()
        {
            
        }

        public void abrir(Llave l)
        {
            if (l.getforma() == candado && cerrado==true)
            {
                cerrado=false;
                Console.WriteLine("Este candado ya ha sido abierto");
            }
            else {
                if (cerrado==false)
                {
                    Console.WriteLine("El candado ya está abierto");
                }else Console.WriteLine("La llave no es la correcta");
            }
        }

        public void ponerTesoro()
        {
            this.contenido = "Moneda de Oro";
        }
    }
}
