

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


        

        Random random = new Random();
        String input="";
        int n=0;
        bool exit=false;

        while (exit==false)
        {
            String titulo = "\t\t***Coffin Opener*** \n\n";
            String menu1 = titulo + "1) Jugar \n" +
                                  "2) Cómo jugar \n" +
                                  "3) Salir";
            String menu2 = titulo + "Elija la cantidad de cofres entre 3 y 10:";



            n = menúSelección(0, 4, menu1);

            switch (n)
            {
                case 1:


                    //JUEGO-------------------------------------------------------------JUEGO-------------------
                    //
                    //
                    n = menúSelección(2, 25, menu2);

                    Cofre[] cofres = new Cofre[n];
                    Llave[] llaves = new Llave[n];
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(titulo);
                    Txt.instrucciones();
                    break;
                case 3:
                    exit = true;
                    Txt.salir();
                    break;

            }
        }



    }
    
    //------------------------------------------------------------------------------------------------------
    //------------------------------------------------------------------------------------------------------
    
    //Metodos y funciones utilizados:



    static int menúSelección(int num1, int num2, String menu)
    {
        String input;
        int x = 0;
        bool a=false;
        while (a==false) { 
        
            Console.Clear();
            Console.WriteLine(menu);
            Console.WriteLine("\nIngrese una opción: \n");
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                // Asignando un valor predeterminado si la entrada está vacía
                input = "Imbecil";
            }

            if (int.TryParse(input, out int _n))
            {
                x = int.Parse(input);
                if (num1 >= x || x >= num2)
                {
                    Console.WriteLine("Ingrese una opción válida");
                    Thread.Sleep(1500);
                }
                else a=true;
            }
            else
            {
                Console.WriteLine("\nEntrada no válida. Asegúrese de ingresar un número entero.");
                Thread.Sleep(1500);
            }
            
            
        }
        return x;
    }
    
}