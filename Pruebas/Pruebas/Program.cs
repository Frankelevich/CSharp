

namespace Pruebas;

class Pruebas
{
    static void Main(string[] args)
    {
        //Se debe colocar la cantidad de elementos (de 3 para arriba). La cantidad
        //de oportunidades para abrir cofres será 2 en caso de elegir 3 cofres.
        //Para 4-7 serán n-2 chances y se podrá intentar romper una vez un cofre.
        //A partir de 8 los intentos serán siempre 5 con 2 posibilidades de romper
        //y a partir de 12 las oportunidades para romper se incrementan en 1.
        //Para 20 en adelante, serán 7 chances y 10 oportunidades para romper un cofre.


        
        String input="";
        int n=0;
        bool exit=false;

        while (exit==false)
        {
            String titulo = "\t\t***Coffin Opener*** \n\n";

            String menu1 = titulo + "1) Jugar \n" +
                                  "2) Cómo jugar \n" +
                                  "3) Salir";

            String menu2 = titulo + "Elija la cantidad de cofres entre 3 y 25:";


            n = Mecanicas.menúSelección(1, 3, menu1);

            switch (n)
            {
                case 1:


                    //JUEGO---------------------------------------------------------------------------------------------------------------------------------------------JUEGO
                    //
                    //
                    n = Mecanicas.menúSelección(3, 25, menu2);

                    List<Cofre> cofres = new List<Cofre>(n);
                    List<Llave> llaves = new List<Llave>(n);

                    Mecanicas.setElementos(cofres, llaves, n);


                    break;
                    //---------------------------------------------------------------------------------------------------------------------------------------------------FIN JUEGO
                case 2:
                    Console.Clear();
                    Console.WriteLine(titulo);
                    Texto.instrucciones();
                    break;
                case 3:
                    int u=Texto.confirmar(ref n);
                    if (u == 1) 
                    {
                        exit = true;
                        Texto.salir();
                    }           
                    break;

            }
        }



    }
    
}