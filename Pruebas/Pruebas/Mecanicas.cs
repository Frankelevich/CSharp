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

            for (int i = 0; i < n; i++)
            {
                int x;
                do
                {
                    x = random.Next(n);
                    
                } while (repetido1(cofres, x));//Hacemos uso del método que hay más abajo

                Cofre nuevoCofre = new Cofre(x);
                cofres.Add(nuevoCofre);
            }

            for (int i = 0; i < n; i++)
            {
                int x;
                do
                {
                    x = random.Next(n);

                } while (repetido2(llaves, x));//Acá el mismo método modificado para llaves

                Llave nuevaLlave = new Llave(x);
                llaves.Add(nuevaLlave);
            }




            cofres[random.Next(0, cofres.Count)].setContenido(); //Ponemos un diamante en un cofre 

            
            
            static bool repetido1(List<Cofre> cofres, int x)//metodo para saber si se repite un cofre
            {
                foreach (Cofre cofre in cofres)
                {
                    if (cofre.getCandado() == x)
                    {
                        return true;
                    }
                }
                return false;
            }
                         
            static bool repetido2(List<Llave> llaves, int x)//metodo para saber si se repite una llave
            {
                foreach (Llave llave in llaves) 
                {
                    if (llave.getforma() == x)
                    {
                        return true;
                    }
                }
                return false;
            }

        }


        public static void seleccionCofre(ref List<Cofre> cofres, ref List<Llave> llaves, int n)
        {
            //Mecanicas del juego en ejecucuión
        }




}
}
