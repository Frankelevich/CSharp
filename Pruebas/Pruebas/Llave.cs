using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Llave
    {
        Random random = new Random();
        private int forma;


        public Llave(int forma) { 
            this.forma= random.Next(1,forma);
        }

        public int getforma() { 
            return forma; }


    }
}
