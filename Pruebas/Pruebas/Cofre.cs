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
        private String[] basura= {"Taza rota","Pan rancio","Esqueleto de rata","Cabeza de pescado"};
        private String contenido; 

        private bool dureza; //Con esto sabremos si se puede romper el cofre
        public Cofre(int _candado) {
            
            this.contenido= basura[random.Next(basura.Length)];
            this.candado= _candado;
            this.cerrado=true;
            
        }

        

        public void setCandado(int c)
        {
            this.candado= c;
        }

        public int getCandado()
        {
            return this.candado;
        }

        public void setDureza()
        {
            
        }

        public String getContenido(Llave l)
        {
            if (cerrado == true && l.getforma() == candado)

            {
                cerrado = false;
                Console.WriteLine("Abriendo candado");
                return $"El candado contiene: {contenido}";
            }
            else {
                if (cerrado == false)
                {
                    Console.WriteLine("El candado ya está abierto");
                    return $"El candado contiene: {contenido}";
                }
                else return "La llave no coincide con la cerradura del candado";

            }
        }

        public void setContenido()
        {
            this.contenido = "Diamante";
        }
    }
}
