using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Mecanicas
    { 
        //Establezco intentos:
        public static void setIntentos(int n,int _a, int _b)
        {
            _a = n;

            switch (n)
            {
                case 3:
                    _a = n+1;
                    break;
                case 4:
                case 5:
                case 6:
                    _b = 1;
                    break;
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                    _a =7;
                    _b =2;
                    break;
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                    _b=n-9;
                    break;
                default: 
                    _a = 12;
                    _b = 10;
                    break;
            }

        }    
        //Creamos la lista de los cofres y llaves con sus "codigos" de forma aleatoria:
        public static void setElementos(ref List<Cofre> cofres, ref List<Llave> llaves, int n)
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

            cofres[random.Next(0, cofres.Count)].setContenido(); //Ponemos un diamante en un cofre 

        }






}
}
